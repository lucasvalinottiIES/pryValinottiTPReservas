using System.Reflection.Metadata.Ecma335;

namespace pryValinottiTPReservas
{
    public partial class frmReserva : Form
    {
        List<Button> areaAzul = new List<Button>();
        List<Button> areaVerde = new List<Button>();
        List<Button> reservaQuenaken = new List<Button>();
        List<Button> reservaOnas = new List<Button>();
        List<Button> reservaTobas = new List<Button>();
        public frmReserva()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            limpiarAsientos(areaAzul);
            limpiarAsientos(areaVerde);
            areaAzul.Clear();
            areaVerde.Clear();
            int posX = 93;
            int posY = 102;
            if (cbTeatro.Text == "Quenaken")
            {
                limpiarAsientos(reservaTobas);
                limpiarAsientos(reservaOnas);
                foreach (Button reservado in reservaQuenaken)
                {
                    reservado.Enabled = false;
                    this.Controls.Add(reservado);
                }
                posY = cargarArea(posX, posY, 4, 5, Color.Blue);
                posY = cargarArea(posX, posY, 4, 5, Color.Green);
            }
            else if (cbTeatro.Text == "Onas")
            {
                limpiarAsientos(reservaTobas);
                limpiarAsientos(reservaQuenaken);
                foreach (Button reservado in reservaOnas)
                {
                    reservado.Enabled = false;
                    this.Controls.Add(reservado);
                }
                posX = posX + 18;
                posY = cargarArea(posX, posY, 10, 4, Color.Blue);
                posX = 93;
                posY = cargarArea(posX, posY, 4, 5, Color.Green);
            }
            else if (cbTeatro.Text == "Tobas")
            {
                limpiarAsientos(reservaQuenaken);
                limpiarAsientos(reservaOnas);
                foreach (Button reservado in reservaTobas)
                {
                    reservado.Enabled = false;
                    this.Controls.Add(reservado);
                }
                posX = posX + 30;
                posY = cargarArea(posX, posY, 4, 3, Color.Blue);
                posX = 93;
                posY = cargarArea(posX, posY, 3, 5, Color.Green);
            }
        }

        private int cargarArea(int posX, int posY, int filas, int columnas, Color area)
        {
            int posXInicial = posX;
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Button asiento = new Button();
                    asiento.FlatStyle = FlatStyle.Flat;
                    asiento.Cursor = Cursors.Hand;
                    asiento.BackColor = area;
                    asiento.Size = new Size(18, 18);
                    asiento.Location = new Point(posX, posY);
                    asiento.Click += new EventHandler(reservarAsiento);
                    this.Controls.Add(asiento);
                    areaAzul.Add(asiento);
                    posX += 30;
                }
                posX = posXInicial;
                posY += 22;
            }
            return posY;
        }

        private void limpiarAsientos(List<Button> area)
        {
            foreach (Button asiento in area)
            {
                this.Controls.Remove(asiento);
            }
        }

        private void reservarAsiento(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            boton.BackColor = Color.Gray;
            if (cbTeatro.Text == "Quenaken") reservaQuenaken.Add(boton);
            else if (cbTeatro.Text == "Onas") reservaOnas.Add(boton);
            else if (cbTeatro.Text == "Tobas") reservaTobas.Add(boton);
        }

        private void cmdConfirmarReserva_Click(object sender, EventArgs e)
        {
            if (cbTeatro.Text == "Quenaken") confirmarReserva(reservaQuenaken);
            else if (cbTeatro.Text == "Onas") confirmarReserva(reservaOnas);
            else if (cbTeatro.Text == "Tobas") confirmarReserva(reservaTobas);
        }

        private void confirmarReserva(List<Button> reserva)
        {
            foreach (Button asiento in reserva)
            {
                asiento.BackColor = Color.Red;
                asiento.Enabled = false;
            }
        }
    }
}