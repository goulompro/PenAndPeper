using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PenAndPepper
{
    public partial class FormCombat : Form
    {
        List<Panel> EnemyPanelList = new List<Panel>();
        List<Label> EnemyNameTextList = new List<Label>();
        List<Label> EnemyLifepointsTextList = new List<Label>();
        List<ProgressBar> EnemyLifePointsProgressList = new List<ProgressBar>();
        List<PictureBox> EnemySpritePictureList = new List<PictureBox>();
        List<Button> EnemyAttackButtonList = new List<Button>();

        List<Character> enemyList = new List<Character>();
        public List<Character> PlayerList = new List<Character>();
        
        public FormCombat(List<Character> figures, Field.FieldTyp fieldTyp)
        {
            InitializeComponent();
            PlayerList = figures;
            enemyList = AddEnemys(fieldTyp);

            
            AddEnemysPanels();
        }

        private List<Character> AddEnemys(Field.FieldTyp fieldTyp)
        {
            List<Character> enemys = new List<Character>();
            Random rnd             = new Random();
            int maxEnemys          = rnd.Next(1,5);
            EnemyList enemyList    = new EnemyList();
            enemyList.Get_saved_Enemys("enemys.csv");
            do
            {
                int rndEnemy = rnd.Next(rnd.Next(1, enemyList.Enemies.Count() - 1));
                Enemy enemy = new Enemy();
                enemy.Name = enemyList.Enemies[rndEnemy].Name;
                enemy.Lifepoints = enemyList.Enemies[rndEnemy].Lifepoints;
                enemy.Strength = enemyList.Enemies[rndEnemy].Strength;
                switch (fieldTyp)
                {
                    case Field.FieldTyp.forrest:
                        if(enemyList.Enemies[rndEnemy].Spawnforrest)
                        {
                            enemys.Add(enemy);
                        }
                        break;
                    case Field.FieldTyp.plains:
                        if (enemyList.Enemies[rndEnemy].Spawnplains)
                        {
                            enemys.Add(enemy);
                        }
                        break;
                    case Field.FieldTyp.mountain:
                        if (enemyList.Enemies[rndEnemy].Spawnmountain)
                        {
                            enemys.Add(enemy);
                        }
                        break;
                    case Field.FieldTyp.town:
                        //Nicht genutzt
                        MessageBox.Show("Ein Fehler ist aufgetreten", "Kampf in Stadt");
                        break;
                    case Field.FieldTyp.lake:
                        if (enemyList.Enemies[rndEnemy].Spawnlake)
                        {
                            enemys.Add(enemy);
                        }
                        break;
                    default:
                        break;
                }
            } while (enemys.Count() < maxEnemys);
            return enemys;
        }

        private void AddEnemysPanels()
        {
            for (int i = 0; i < enemyList.Count(); i++)
            {
                Panel EnemyPanel = new Panel
                {
                    BorderStyle = BorderStyle.FixedSingle,
                    Size = new Size(134, 229),
                    Location = new Point(12 + i * 140, 12)
                };
                EnemyPanelList.Add(EnemyPanel);

                Label EnemyNameText = new Label
                {
                    Text = enemyList[i].Name,
                    Location = new Point(3, 134)
                };
                EnemyNameTextList.Add(EnemyNameText);

                Label EnemyLifepointsText = new Label
                {
                    Text = Convert.ToString(enemyList[i].Lifepoints),
                    Location = new Point(3, 156)
                };
                EnemyLifepointsTextList.Add(EnemyLifepointsText);

                ProgressBar EnemyLifePointsProgress = new ProgressBar
                {
                    Maximum = Convert.ToInt32(enemyList[i].Lifepoints),
                    Value = Convert.ToInt32(enemyList[i].Lifepoints),
                    Location = new Point(3, 172)
                };
                EnemyLifePointsProgressList.Add(EnemyLifePointsProgress);

                PictureBox EnemySpritePicture = new PictureBox
                {
                    Size = new Size(128, 128),
                    Location = new Point(3, 3),
                    Image = Image.FromFile("Sprites//" + enemyList[i].Name + ".png")
                };
                EnemySpritePictureList.Add(EnemySpritePicture);

                Button EnemyAttackButton = new Button
                {
                    Text = "Angreifen",
                    Size = new Size(128, 23),
                    Location = new Point(3, 203)
                };
                EnemyAttackButton.Click += new EventHandler(Btn_Attack_Click);
                EnemyAttackButtonList.Add(EnemyAttackButton);
                
                EnemyPanelList[i].Controls.Add(EnemySpritePictureList[i]);
                EnemyPanelList[i].Controls.Add(EnemyNameTextList[i]);
                EnemyPanelList[i].Controls.Add(EnemyLifepointsTextList[i]);
                EnemyPanelList[i].Controls.Add(EnemyLifePointsProgressList[i]);
                EnemyPanelList[i].Controls.Add(EnemyAttackButtonList[i]);
                this.Controls.Add(EnemyPanelList[i]);
            }
        }

        private void Round()
        {
            //Mach Sachen
            EnemyLifePointsRefresh();
            if(!CheckEnd())
            {
                EnemyAttack();
                CheckEnd();
            }
        }

        private bool CheckEnd()
        {
            if(CheckEnemy() || CheckPlayer())
            {
                return true;
            }
            return false;
        }

        private bool CheckPlayer()
        {
            foreach (Character p in PlayerList)
            {
                if (p.Lifepoints > 0)
                {
                    return false;
                }
            }
            MessageBox.Show("Sie haben verloren! GAME OVER!", "Test");
            this.Close();
            return true;
        }

        private bool CheckEnemy()
        {
            foreach (Character e in enemyList)
            {
                if (e.Lifepoints > 0)
                {
                    return false;
                }
            }
            MessageBox.Show("Sie haben den Kampf gewonnen!", "Test");
            this.Close();
            return true;
        }

        private void EnemyLifePointsRefresh()
        {
            for (int i = 0; i < enemyList.Count(); i++)
            {
                EnemyLifepointsTextList[i].Text = Convert.ToString(enemyList[i].Lifepoints);
                EnemyLifePointsProgressList[i].Value = Convert.ToInt32(enemyList[i].Lifepoints);
                if (enemyList[i].Lifepoints == 0)
                {
                    EnemySpritePictureList[i].Image = Image.FromFile("Sprites//dead.png");
                    EnemyAttackButtonList[i].Enabled = false;
                }
            }
        }

        private void EnemyAttack()
        {
            for (int i = 0; i < enemyList.Count(); i++)
            {
                if (enemyList[i].Lifepoints > 0)
                {
                    Random rnd = new Random();
                    int target;
                    do
                    {
                        target = rnd.Next(0, PlayerList.Count());
                    } while (PlayerList[target].Lifepoints < 0);
                    PlayerList[target].Lifepoints = Math.Max(PlayerList[target].Lifepoints - enemyList[i].Strength, 0);

                    List<string> combatlog = txt_CombatLog.Lines.ToList();
                    combatlog.Add(enemyList[i].Name + " trifft " + PlayerList[target].Name + " und macht " + enemyList[i].Strength + " Schaden.");
                    txt_CombatLog.Lines = combatlog.ToArray();
                }
            }
        }

        private void Btn_Attack_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < EnemyAttackButtonList.Count(); i++)
            {
                if (EnemyAttackButtonList[i] == sender as Button)
                {
                    for(int j = 0; j < PlayerList.Count(); j++)
                    {
                        if(PlayerList[j].Lifepoints > 0)
                        {
                            enemyList[i].Lifepoints = Math.Max(enemyList[i].Lifepoints - PlayerList[j].Strength, 0);
                            List<string> combatlog = txt_CombatLog.Lines.ToList();
                            combatlog.Add(PlayerList[j].Name + " trifft " + enemyList[i].Name + " und macht " + PlayerList[i].Strength + " Schaden.");
                            txt_CombatLog.Lines = combatlog.ToArray();
                        }
                    }
                    
                }
            }
            Round();
        }

        private void Btn_Flee_Click(object sender, EventArgs e)
        {
            //FightEnd();
            int exeriencecount = EnemyPanelList.Count;
            Round();
        }

        public void FormCombat_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
