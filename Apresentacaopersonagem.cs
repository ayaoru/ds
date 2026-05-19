using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Net.Http.Headers;

namespace POO
{
    class Apresentacao:Form
    {
        // criar um objeto do automovel
        Imagem carr01 = new Personagem();

        // Objeto
        PictureBox img = new PictureBox();
        Label txtNome = new Label();
        Label txtNomeObra = new Label();
        Label txtTipoObra = new Label();
        Label txtAno = new Label();
        // toda classe tem um construtor
        public Apresentacao() {
            this.Text = "Apresentação de Instrumentos";
            this.Size = new Size(600, 600);
            btobj01.Text = " Clicar ";
            btobj01.Location = new Point(50, 50);
            btobj01.Click += clicar ;

            btobj02.Text = " Herança ";
            btobj02.Location = new Point(50, 100);
            btobj02.Click += Heranca;

            // Control[] controles = new Control[] { txtMarca, btobj01 }; 
            //this.Controls.Add(btobj01);
            this.Controls.AddRange(new Control[] { txtMarca, btobj01, txtVelocidade
            , txtTipo, txtAno, txtModelo, img, btobj02});

        }

        // metodo de Evento
        private void clicar( object sender , EventArgs e ) {
            //MessageBox.Show("Metodo de Evento");
            // fazer apresentação da carro01
            //carr01.SetMarca("Fiat");
            // this.txtMarca.Text = " Marca : " + carr01.GetMarca();
            carr01.Marca = "Fiat";
            carr01.Ano = 2020;
            carr01.Modelo = "Uno";
            carr01.Velocidade = "200 km/h";
           
        
            txtMarca.Text = " Marca : " + carr01.Marca;
            txtModelo.Text = "Tipo :" + carr01.Modelo;
            txtAno.Text = " Ano : " + carr01.Ano;
            txtVelocidade.AutoSize= true;
            txtVelocidade.Text = " Velocidade :  " + carr01.Acelerar(120).ToString(); ;

            this.txtMarca.Location = new Point(100, 100);
            this.txtAno.Location = new Point(100, 130);
            this.txtModelo.Location = new Point(100, 150);          
            this.txtVelocidade.Location = new Point(100, 180);

            // COLOCAR IMAGEM
            img.Image = Image.FromFile(@"C:\Users\LabInfo\source\repos\SojuEu\POO-DS-2BI\IMG\uno.jpg");
            img.SizeMode = PictureBoxSizeMode.AutoSize;
            img.Width = 10;
            img.Height = 10;
            this.img.Location = new Point(50, 100);


        }

       private void Heranca(object sender, EventArgs e)
        {
            Carro Obj01Carro = new Carro("CHEVETTE", "SUV");
            txtMarca.Text = " Nome : " + Obj01Carro.Marca;
            txtTipo.Text = " Tipo : " + Obj01Carro.Modelo;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Apresentacao
            // 
            this.ClientSize = new System.Drawing.Size(278, 244);
            this.Name = "Apresentacao";
            this.Load += new System.EventHandler(this.Apresentacao_Load);
            this.ResumeLayout(false);

        }

        private void Apresentacao_Load(object sender, EventArgs e)
        {

        }
    }
}
