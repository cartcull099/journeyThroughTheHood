using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Media;
//Caretr and Adam
//Journey through the hood
//November 7 2018

namespace journeyThroughTheHood
{
    public partial class HoodAdventure : Form

    {
        //initializing scene variable 
        int scene = 1;
        Random randgen = new Random();
        SoundPlayer player;

        public HoodAdventure()
        {
            InitializeComponent();
            player = new SoundPlayer(Properties.Resources.scream2);
        }

        private void HoodAdventure_KeyDown(object sender, KeyEventArgs e)
        {
            //switch case with Q
            if (e.KeyCode == Keys.Q)
            {
                if (scene == 1)
                {
                    scene = 2;
                }

                else if (scene == 2)
                {
                    scene = 3;
                }

                else if (scene == 3)
                {
                    int randomValue = randgen.Next(1, 3);
                    if (randomValue == 1)
                    {
                        scene = 4;
                    }
                    else
                    {
                        scene = 5;
                    }

                }
                else if (scene == 4)
                {
                    scene = 1;
                }

                else if (scene == 5)
                {
                    scene = 6;
                }

                else if (scene == 6)
                {
                    scene = 1;
                }

                else if (scene == 7)
                {
                    scene = 8;
                }

                else if (scene == 8)
                {
                    scene = 1;
                }

                else if (scene == 9)
                {
                    scene = 1;
                }

                else if (scene == 10)
                {
                    scene = 11;
                }

                else if (scene == 11)
                {
                    scene = 1;
                }

                else if (scene == 12)
                {
                    scene = 13;
                    buttE.Visible = false;
                    eLabel.Text = "";
                }

                else if (scene == 13)
                {
                    scene = 1;
                }

                else if (scene == 14)
                {
                    scene = 1;
                }

                else if (scene == 15)
                {
                    scene = 1;
                }

                else if (scene == 16)
                {
                    scene = 17;
                }

                else if (scene == 17)
                {
                    scene = 1;
                }

                else if (scene == 18)
                {
                    scene = 19;
                }

                else if (scene == 19)
                {
                    scene = 1;
                }

                else if (scene == 20)
                {
                    scene = 21;
                }

                else if (scene == 21)
                {
                    scene = 1;
                }

                else if (scene == 22)
                {
                    scene = 23;
                    buttE.Visible = false;
                    eLabel.Text = "";
                }

                else if (scene == 23)
                {
                    scene = 1;
                }

                else if (scene == 24)
                {
                    scene = 1;
                }

                else if (scene == 25)
                {
                    scene = 1;
                }




            }
            //switch case with W
            else if (e.KeyCode == Keys.W)
            {
                if (scene == 3)
                {
                    scene = 5;
                }

                else if (scene == 4)
                {
                    scene = 26;
                }

                else if (scene == 5)
                {
                    scene = 7;
                }

                else if (scene == 6)
                {
                    scene = 26;
                }

                else if (scene == 7)
                {
                    scene = 9;
                }

                else if (scene == 8)
                {
                    scene = 26;
                }

                else if (scene == 9)
                {
                    scene = 26;
                }

                else if (scene == 2)
                {
                    scene = 10;
                }

                else if (scene == 10)
                {
                    scene = 12;
                    buttE.Visible = true;
                }

                else if (scene == 11)
                {
                    scene = 26;
                }

                else if (scene == 12)
                {
                    scene = 14;
                    buttE.Visible = false;
                    eLabel.Text = "";
                }

                else if (scene == 14)
                {
                    scene = 26;
                }

                else if (scene == 15)
                {
                    scene = 26;
                }

                else if (scene == 1)
                {
                    scene = 16;
                }

                else if (scene == 16)
                {
                    scene = 18;
                }

                else if (scene == 17)
                {
                    scene = 26;
                }

                else if (scene == 18)
                {
                    scene = 20;
                }

                else if (scene == 19)
                {
                    scene = 26;
                }

                else if (scene == 20)
                {
                    scene = 22;
                    buttE.Visible = true;
                }

                else if (scene == 21)
                {
                    scene = 26;
                }

                else if (scene == 22)
                {
                    scene = 24;
                    buttE.Visible = false;
                    eLabel.Text = "";
                }

                else if (scene == 23)
                {
                    scene = 26;
                }

                else if (scene == 24)
                {
                    scene = 26;
                }

                else if (scene == 25)
                {
                    scene = 26;
                }

            }
            //switch case with E
            else if (e.KeyCode == Keys.E)
            {
                if (scene == 12)
                {
                    scene = 15;
                    buttE.Visible = false;
                    eLabel.Text = "";
                }

                else if (scene == 22)
                {
                    scene = 25;
                    buttE.Visible = false;
                    eLabel.Text = "";
                }

            }

            switch (scene)
            {
                //cases
                case 1:
                    outputLabel.Text = "You come out of work at 9pm and it's pouring rain. Do you?";
                    qLabel.Text = "Take the Bus";
                    wLabel.Text = "Walk Home";
                    BackgroundImage = Properties.Resources.rain;
                    break;

                case 2:
                    outputLabel.Text = "On the bus you encounter a drug addict who wants you to help him make a sale. Do you?";
                    qLabel.Text = "Stay on the Bus";
                    wLabel.Text = "Go with him at the next stop";
                    BackgroundImage = Properties.Resources.drug_adict;
                    break;

                case 3:
                    outputLabel.Text = "You stay on the bus and find a bomb under the dealers seat. Do you?";
                    qLabel.Text = "Alert the other passengers,\nyour voice may or may not work";
                    wLabel.Text = "Keep it quiet";
                    BackgroundImage = Properties.Resources.bomb;
                    break;


                case 4:
                    outputLabel.Text = "Your voice works so you cause a panic causing the bus driver to crash, leading to your horrible death. Do you?";
                    qLabel.Text = "Play Again";
                    wLabel.Text = "Exit";
                    BackgroundImage = Properties.Resources.Dead;
                    player.Play();
                    break;

                case 5:
                    outputLabel.Text = "You keep quiet and get off the bus at the next stop. The bus explodes and people die horribly. Do you?";
                    qLabel.Text = "Help the survivors";
                    wLabel.Text = "Save yourself";
                    BackgroundImage = Properties.Resources.Explosion;
                    break;

                case 6:
                    outputLabel.Text = "You run into the fire to help, but you burn and die horribly. Do you?";
                    qLabel.Text = "Play Again";
                    wLabel.Text = "Exit";
                    BackgroundImage = Properties.Resources.Dead;
                    player.Play();
                    break;

                case 7:
                    outputLabel.Text = "You let them burn and run from the scene, When you're almost home, you find a magic bag of drugs. Do you?";
                    qLabel.Text = "Report it to the Police";
                    wLabel.Text = "Use the drugs";
                    BackgroundImage = Properties.Resources.Drugs;
                    break;

                case 8:
                    outputLabel.Text = "The police think the drugs are yours so you go to prison, where you die a horrible death. Do you?";
                    qLabel.Text = "Play Again";
                    wLabel.Text = "Exit";
                    BackgroundImage = Properties.Resources.Dead;
                    player.Play();
                    break;

                case 9:
                    outputLabel.Text = "The drugs give you superpowers and you live happily ever after. Do you?";
                    qLabel.Text = "Play Agian";
                    wLabel.Text = "Exit";
                    BackgroundImage = Properties.Resources.Superpowers;
                    break;

                case 10:
                    outputLabel.Text = "You leave the bus with him and go to an alleway where the buyer does not show up, so he offers them to you. Do you?";
                    qLabel.Text = "Use the drugs";
                    wLabel.Text = "Walk away";
                    BackgroundImage = Properties.Resources.Alleyway;
                    break;

                case 11:
                    outputLabel.Text = "The drugs were laced with laxatives, so you poop your guts out and die horribly. Do you?";
                    qLabel.Text = "Play Again";
                    wLabel.Text = "Exit";
                    BackgroundImage = Properties.Resources.Dead;
                    player.Play();
                    break;

                case 12:
                    outputLabel.Text = "You leave the guy, but come across the goon squad, who mistakes you for the dealer and wants to kill you. Do you?";
                    qLabel.Text = "Fight Ethan Zehr";
                    wLabel.Text = "Fight Julien Notte";
                    eLabel.Text = "Fight Carter Culliton";
                    BackgroundImage = Properties.Resources.Julien_Notte;
                    break;

                case 13:
                    outputLabel.Text = "You brutally murder Ethan Zehr and are welcomed to the group. Do you?";
                    qLabel.Text = "Play Again";
                    wLabel.Text = "Exit";
                    BackgroundImage = Properties.Resources.Gang;
                    break;

                case 14:
                    outputLabel.Text = "You fight Julien and die a horrible death. Do you?";
                    qLabel.Text = "Play Again?";
                    wLabel.Text = "Exit";
                    BackgroundImage = Properties.Resources.Dead;
                    player.Play();
                    break;

                case 15:
                    outputLabel.Text = "You fight Carter and die a horrible death. Do you?";
                    qLabel.Text = "Play Again";
                    wLabel.Text = "Exit";
                    BackgroundImage = Properties.Resources.Dead;
                    player.Play();
                    break;

                case 16:
                    outputLabel.Text = "You walk for a bit and go under a bridge, where you are followed by a suspicious homeless man. Do you?";
                    qLabel.Text = "Run away";
                    wLabel.Text = "Ignore him";
                    BackgroundImage = Properties.Resources.Real_Homeless;
                    break;

                case 17:
                    outputLabel.Text = "You try to run but trip over a rock, and the homeless man brutally murders you. Do you?";
                    qLabel.Text = "Play Again";
                    wLabel.Text = "Exit";
                    BackgroundImage = Properties.Resources.Dead;
                    player.Play();
                    break;

                case 18:
                    outputLabel.Text = "The Homeless man corners you in an alley, so you have to fight. Do you?";
                    qLabel.Text = "Uppercut";
                    wLabel.Text = "Kick in the balls";
                    BackgroundImage = Properties.Resources.Alleyway;
                    break;

                case 19:
                    outputLabel.Text = "On the wind up, you twist your ankle, and he brutally murders you. Do you?";
                    qLabel.Text = "Play Again";
                    wLabel.Text = "Exit";
                    BackgroundImage = Properties.Resources.Dead;
                    player.Play();
                    break;

                case 20:
                    outputLabel.Text = "Your kick ruptures all his organs, and he dies a horrible death, the police are coming. Do you?";
                    qLabel.Text = "Wait for Police";
                    wLabel.Text = "Flee the scene";
                    BackgroundImage = Properties.Resources.Kick;
                    break;

                case 21:
                    outputLabel.Text = "You are sent to prison where you die horribly. Do you?";
                    qLabel.Text = "Play Again";
                    wLabel.Text = "Exit";
                    BackgroundImage = Properties.Resources.Dead;
                    player.Play();
                    break;

                case 22:
                    outputLabel.Text = "You are almost home but you come upon a gang lead by Homie-G-Dawg-Spider-Wasp-Bee. Do you?";
                    qLabel.Text = "Make a break for home";
                    wLabel.Text = "Try to fight";
                    eLabel.Text = "Join the gang";
                    BackgroundImage = Properties.Resources.Gang;
                    break;

                case 23:
                    outputLabel.Text = "You run and get shot in the back and die horribly. Do you?";
                    qLabel.Text = "Play Again";
                    wLabel.Text = "Exit";
                    BackgroundImage = Properties.Resources.Dead;
                    player.Play();
                    break;

                case 24:
                    outputLabel.Text = "You try to fight and get brutally murdered. Do you";
                    qLabel.Text = "Play Again";
                    wLabel.Text = "Exit";
                    BackgroundImage = Properties.Resources.Dead;
                    player.Play();
                    break;

                case 25:
                    outputLabel.Text = "You become part of the gang and live happily ever after. Do you?";
                    qLabel.Text = "Play Again";
                    wLabel.Text = "Exit";
                    BackgroundImage = Properties.Resources.Gang;
                    break;

                case 26:
                    outputLabel.Text = "Game over... Better luck next time!";
                    Thread.Sleep(3000);
                    Close();
                    break;
            }

        }

     
    }
}

