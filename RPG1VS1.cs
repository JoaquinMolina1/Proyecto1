using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal2
{
    public partial class Form1 : Form
    {

        private int playerHP = 100; //ACÁ LO QUE HAGO ES GUARDAR LA VIDA DEL PERSONAJE Y ENEMIGO EN UNA VARIABLE.
        private int enemyHP = 100;
        private Random random = new Random(); //ACÁ CREO UN NÚMERO ALEATORIO PARA QUE LOS ATAQUE NO SIEMPRE HAGAN EL MISMO DAÑO.

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            int playerDamage = random.Next(10, 20); //GENERO UN DAÑO ALEATORIO ENTRE 10 Y 20.
            enemyHP -= playerDamage; //ACÁ SE DESCUENTA EL DAÑO GENERADO POR EL PERSONAJE AL ENEMIGO.
            lblEnemyHP.Text = $"Enemigo HP: {enemyHP}"; //ACÁ DICE CUANTO ES EL DAÑO EJERCIDO.

            if (enemyHP <= 0)
            { MessageBox.Show("El enemigo ha sido derrotado.");
                ResetGame();
                return;
            }
            EnemyTurn();
        }

        private void btnDefend_Click(object sender, EventArgs e)
        {
            int reducedDamage = random.Next(5, 10); //ACÁ GENERO LA DEFENSA ENTRE 5 Y 10.
            playerHP -= reducedDamage;
            lblPlayerHP.Text = $"Jugador HP: {playerHP}";

            if (playerHP <= 0)
            {
                MessageBox.Show("Has sido derrotado...");
                ResetGame();

            }
        }
        private void EnemyTurn()
        {
            int enemyDamage = random.Next(10, 15);
            playerHP -= enemyDamage;
            lblPlayerHP.Text = $"Jugador HP: {playerHP}";

            if (playerHP <= 0)
            {
                MessageBox.Show("Has sido derrotado...");
                ResetGame();
            }
        }
        private void ResetGame()
        { playerHP = 100;
            enemyHP = 100;
            lblPlayerHP.Text = "Jugador HP: 100";
            lblEnemyHP.Text = " Enemigo HP: 100";
        }
    }
}
