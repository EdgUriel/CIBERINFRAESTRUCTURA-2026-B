using System.Text.RegularExpressions;

namespace HolaMundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Recuperamos la contraseña y su confirmación desde los campos del formulario.
            string password = textBox1.Text;
            string confirmacion = textBox2.Text;

            // La expresión regular comprueba que exista al menos una mayúscula, una minúscula, un número y un símbolo.
            string patron = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^A-Za-z0-9\s]).+$";

            // Primero se revisa que la contraseña cumpla con la estructura solicitada.
            if (!Regex.IsMatch(password, patron))
            {
                MessageBox.Show(
                    "La contraseña debe contener al menos una letra mayúscula, " +
                    "una letra minúscula, un número y un símbolo.",
                    "Contraseña no válida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Si la contraseña es válida, comprobamos que ambos campos coincidan.
            if (password != confirmacion)
            {
                MessageBox.Show(
                    "Las contraseñas no coinciden.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Si las dos validaciones anteriores se cumplen, el proceso fue correcto.
            MessageBox.Show(
                "La contraseña ha sido validada",
                "Validación correcta",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}