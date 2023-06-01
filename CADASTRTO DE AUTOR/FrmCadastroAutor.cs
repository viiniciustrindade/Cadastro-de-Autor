using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;
using Label = System.Windows.Forms.Label;
using ToolTip = System.Windows.Forms.ToolTip;

namespace CADASTRTO_DE_AUTOR
{
    public partial class FrmCadastroAutor : Form
    {
        public FrmCadastroAutor()
        {
            InitializeComponent();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Valida se o campo for NULL do banco, VAZIO = "" OU " "
            if (string.IsNullOrEmpty(txtNomeAutor.Text) || string.IsNullOrWhiteSpace(txtNomeAutor.Text))
            {
                MessageBox.Show("Informe o campo [Nome]");
                return;
            }
            // Valida se o campo for NULL do banco, VAZIO = "" OU " "
            else if (string.IsNullOrEmpty(txtDescAutor.Text) || string.IsNullOrWhiteSpace(txtDescAutor.Text))
            {
                MessageBox.Show("Informe o campo [Descrição]");
                return;
            }


            try
            {
                using (SqlConnection connection = DaoConnection.GetConexao())
                {
                    AutorDAO dao = new AutorDAO(connection);

                    string sql2 = "SELECT COUNT(codAutor) FROM mvtBibAutor WHERE codAutor = @codAutor";
                    SqlCommand cmdSelect = new SqlCommand(sql2, connection);
                    cmdSelect.Parameters.AddWithValue("@codAutor", txtcodAutor.Text);
                    int count = Convert.ToInt32(cmdSelect.ExecuteScalar());

                    if (count > 0)
                    {
                        dao.Alterar(new AutorModel()
                        {
                            codAutor = txtcodAutor.Text,
                            nomeAutor = txtNomeAutor.Text,
                            descricao = txtDescAutor.Text
                        });


                    }
                    else
                    {
                        dao.Salvar(new AutorModel()
                        {
                            nomeAutor = txtNomeAutor.Text,
                            descricao = txtDescAutor.Text
                        });
                    }


                    MessageBox.Show("Autor salvo com sucesso!");
                    // se salvar deu certo carrega os usuários
                    CarregarUsuariosGrid();
                    LoadID();
                    btn_Excluir.Enabled = false;
                    txtNomeAutor.Text = "";
                    txtDescAutor.Text = "";
                }
            }
            catch (Exception ex)
            {
                // se salvar deu errado mostra mensagem
                MessageBox.Show($"Houve um problema ao salvar o usuário!\n{ex.Message}");
            }
            

        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            // Valida se o campo for NULL do banco, VAZIO = "" OU " "
            if (string.IsNullOrEmpty(txtNomeAutor.Text) || string.IsNullOrWhiteSpace(txtNomeAutor.Text))
            {
                MessageBox.Show("Autor não selecionado");
                return;
            }
            DialogResult confirmacao = MessageBox.Show("Deseja Excluir o Autor?","Atenção",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            try
            {
                if(confirmacao == DialogResult.Yes)
                {
                    using (SqlConnection connection = DaoConnection.GetConexao())
                    {
                        AutorDAO dao = new AutorDAO(connection);
                        dao.Excluir(new AutorModel()
                        {
                            codAutor = txtcodAutor.Text
                        });
                    }
                    MessageBox.Show("Autor excluído com sucesso!");
                    CarregarUsuariosGrid();
                    LoadID();
                    btn_Excluir.Enabled = false;
                    txtNomeAutor.Text = "";
                    txtDescAutor.Text = "";
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Houve um problema ao excluir o autor!\n{ex.Message}");
            }
        }
        private void LoadID() 
        {
            using (SqlConnection connection = DaoConnection.GetConexao())
            {


                SqlCommand cmd = new SqlCommand("SELECT IDENT_CURRENT('mvtBibAutor') + 1", connection);
                int proximoID = Convert.ToInt32(cmd.ExecuteScalar());


                txtcodAutor.Text = proximoID.ToString();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CarregarUsuariosGrid();
            LoadID();
            btn_Excluir.Enabled = false;
        }
        private void CarregarUsuariosGrid()
        {
            dadosGrid.Rows.Clear();
            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                AutorDAO dao = new AutorDAO(connection);
                List<AutorModel> autores = dao.GetAutores();
                foreach (AutorModel autor in autores)
                {
                    DataGridViewRow row = dadosGrid.Rows[dadosGrid.Rows.Add()];
                    row.Cells[colcodigoAutor.Index].Value = autor.codAutor;
                    row.Cells[colnomeDoAutor.Index].Value = autor.nomeAutor; 
                    row.Cells[coldecricaoAutor.Index].Value = autor.descricao;
                }
            }
        }
        private void dadosGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                txtcodAutor.Text = dadosGrid.Rows[e.RowIndex].Cells[colcodigoAutor.Index].Value + "";
                txtNomeAutor.Text = dadosGrid.Rows[e.RowIndex].Cells[colnomeDoAutor.Index].Value + "";
                txtDescAutor.Text = dadosGrid.Rows[e.RowIndex].Cells[coldecricaoAutor.Index].Value + "";
                if (string.IsNullOrEmpty(this.txtNomeAutor.Text))
                {
                    btn_Excluir.Enabled = false;

                }
                else
                {
                    btn_Excluir.Enabled = true;
                }
            }
        }

        private void txtNomeAutor_TextChanged(object sender, EventArgs e)
        {
            if (txtNomeAutor.Text == "")
            {
                asteriscoAlert.Visible = true;  // Mostra a label se o TextBox estiver vazio
            }
            else
            {
                asteriscoAlert.Visible = false; // Oculta a label se o TextBox estiver preenchido
            }
        }

        private void asteriscoAlert_MouseHover(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            string mensagem = "Este Campo é obrigatório!";
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(label, mensagem);
        }

    }
}
