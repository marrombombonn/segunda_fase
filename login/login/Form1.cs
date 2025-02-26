namespace login
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = TextBoxUsuario.Text;
            string senha = TextBoxSenha.Text;
            if (usuario == null || usuario == "")
            {
                LabelResultado.Text = "Usuario e obrigatorio";
                LabelResultado.ForeColor = Color.Green;
            }
            if (senha == null || senha == "")
            {
                LabelResultado.Text = "Senha e obrigatorio";
                LabelResultado.ForeColor = Color.Green;
            }


            if (usuario == "Marcello.Araujo" && senha == "123456")
            {
                LabelResultado.Text = "Autenticado com sucesso";
                LabelResultado.ForeColor = Color.Blue;
            }
            else
            {
                LabelResultado.Text = "Usuario e senha incorreto";
                LabelResultado.ForeColor = Color.Green;
            }

        }
    }
}
