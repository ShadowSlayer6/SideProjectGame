﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Shadow_Warriors
{
	class Program
	{
		#region junk
		#region variable declarations and initializations
		static string[] creatures = new string[] { "Dark Angel", "Shadow Demon", "Forbiden Seeker", "Insane Alchemist", "Enchanted Tome", "Rogue Flame" };
		static double[] creatureAtk = new double[] { 20, 18, 10, 15, 7, 13 };
		static double[] creatureDef = new double[] { 13, 7, 5, 10, 3 };
		static double[] creatureHealth = new double[] { 80, 75, 96, 59, 30, 40 };
		static int baseHealth = 70;
		static int basePhyAttack = 18;
		static int baseMagAttach = 20;
		static int baseDefPrice = 40;
		static int cash = 0;
		static int baseSwordPrice = 20;
		static int baseStaffPrice = 30;
		static int basephyDef = 5;
		static int basemagDef = 10;
		static int magicAp = 30;
		static int phyAp = 30;
		static int exp = 0;
		static int expToNxt = 10;
		static int maxHealth = 100;
		static Random rand = new Random();
		#endregion
#endregion
		static void Main(string[] args)
		{
			#region Full Game
			while (true)
			{
				string Class_Name = "blank";
					#region New Game Loop
				#region Start Up
				string name;
				int dif = 5;
				bool skip = false;
				bool adminAccess = false;
				string shadeKing13 = "False Shadow";
				bool full_game = true;
				int magic_Energy = magicAp;
				bool staff_equiped = false;
				bool sword_equiped = false;
				bool mace_equiped = false;
				string pascode351 = shadeKing13;
				bool dagger_equiped = false;
				int stamina = phyAp;
				string Console_Unlock = "unlock";
				string y = "y";
				string n = "n";
				string A = "A";
				string B = "B";
				string C = "C";
				string D = "D";
				string E = "E";
				string F = "F";
				string G = "G";
				string H = "H";
				string I = "I";
				string J = "J";
				string K = "K";
				string L = "L";
				string M = "M";
				string choice;
				double type = 0;
				#endregion
				while (true)
				{
					Console.Clear();
					Console.WriteLine("Welcome to an adventure unlike any other");
					Console.WriteLine("But first what is your name?");
					name = Console.ReadLine();
					Console.Clear();
					#region System Bypass
					if (name == "system:finite_lock" || name == "system:Finite_Lock" || name == "system:Finite_lock" || name == "system:finite_Lock")
					{
						Console.WriteLine("Bypass system activated");
						Thread.Sleep(2000);
						Console.WriteLine();
						Console.WriteLine("please enter password");
						choice = Console.ReadLine();
						if (choice == pascode351)
						{
							Console.Clear();
							Console.WriteLine("Password Accepted");
							Thread.Sleep(1000);
							Console.WriteLine();
							Console.WriteLine("Bypassing Procedures Initiated");
							Thread.Sleep(1600);
							Console.WriteLine("Access granted");
							Thread.Sleep(2000);
							Console.WriteLine("Welcome Connor");
							adminAccess = true;
							full_game = true;
							name = "Shadow Slayer";
							Thread.Sleep(2000);
							Console.Clear();
							Console.WriteLine("Would you like to skip to the game?");
							choice = Console.ReadLine();
							Console.Clear();
							if (choice == "yes" || choice == "Yes")
							{
								Console.WriteLine("skipping to testing phase of game");
								skip = true;
							}
						}
					}
					#endregion
					if (skip == false)
					{
						Console.Clear();
						Console.WriteLine("alright nice to meet you, " + name);
						Console.WriteLine("so are you ready to begin our adventure (y/n)");
						choice = Console.ReadLine();
						if (choice == y)
						{
							Console.WriteLine("then let us begin");
							Console.ReadLine();
							Console.Clear();
							break;
						}
						else if (choice == n)
						{
							Console.WriteLine("Then why are you even here if not for an adventure?");
							Thread.Sleep(5000);
							Console.WriteLine("really no responce?");
							Thread.Sleep(3000);
							Console.WriteLine("Are you even there?");
							Thread.Sleep(3000);
							Console.WriteLine("Fine then good-bye " + name);
							Thread.Sleep(3000);
							Console.Clear();
							break;
						}
						else
						{
							Console.WriteLine("What was that i can't understand what you said");
							Console.WriteLine("please type y for yes or n for no");
							Console.WriteLine("thank you and have a nice day");
							Thread.Sleep(3000);
						}
						Console.Clear();
						Console.WriteLine("Now time to select the class you want to play as");
						Console.WriteLine("your choices are...");
						while (true)
						{
							dif = 1;
							Console.WriteLine();
							Console.WriteLine("A. Mage");
							Console.WriteLine("B. Knight");
							Console.WriteLine("C. Cleric");
							Console.WriteLine("D. Bandit");
							Console.WriteLine("E. Asaassin");
							Console.WriteLine("F. Swordsman");
							Console.WriteLine();

							if (full_game == true)
							{
								Console.WriteLine();
								Console.WriteLine("for more choices enter the number 2");
								choice = Console.ReadLine();
								if (choice == "2")
								{
									Console.Clear();
									Console.WriteLine("G. Theif");
									Console.WriteLine("H. Meme");
									Console.WriteLine("I. Illuminati");
									Console.WriteLine("J. Youtuber");
									Console.WriteLine("K. Mr. Baker");
									Console.WriteLine("L. Mr. Dodak");
									Console.WriteLine("M. Blank Slate");
									Console.WriteLine();
									Console.WriteLine("Type 1 to see previous options");
									choice = Console.ReadLine();
									if (choice == "1")
									{
										Console.Clear();
									}
								}
							}
							else
							{
								choice = Console.ReadLine();
							}
							Console.Clear();
							if (choice == Console_Unlock)
							{
								Console.WriteLine("System unlocked full access granted");
								full_game = true;
								Console.ReadLine();
							}
							#region Current Access
							#region Mage
							else if (choice == A)
							{
								while (true)
								{
									Console.Clear();
									Console.WriteLine("You have chosen the Mage class");
									Console.WriteLine("you will have a extremly high resistance to most forms of magic but a lot resistence to physical attacks");
									Console.WriteLine("Mages are well versed in Magic in many forms such as fire, electricity, ice, necromancy, and for a small few time");
									Console.WriteLine();
									Console.WriteLine("Now time for you to choose what form of magic you want to be the most proficent in");
									Console.WriteLine("A. Pyromancer");
									Console.WriteLine("B. Shadow");
									Console.WriteLine("C. Storm");
									Console.WriteLine("D. Necromancy");
									Console.WriteLine("E. Transformation");
									Console.WriteLine("F. Back");
									choice = Console.ReadLine();
									#region Time
									if (choice == "Shadow Slayer")
									{
										staff_equiped = true;
										Class_Name = "Time Mage";
										type = 1.1;
										Console.WriteLine("So we have a time mage among us");
										Console.WriteLine("I'm sure you understand that with such a powerful form of magic things will be much more difficult");
										Console.ReadLine();
										Console.Clear();
										break;
									}
									#endregion
									#region Fire
									else if (choice == A || choice == "a")
									{
										staff_equiped = true;
										Class_Name = "Pyromancer";
										type = 1.2;
										Console.WriteLine("As a pyromancer you have the ability to create and controle fire");
										Console.WriteLine("your very soul is fire incarnate");
										Console.WriteLine("you have a high resistence to all forms of fire and fire damage, except dragon fire");
										Console.ReadLine();
										Console.Clear();
										break;
									}
									#endregion
									#region Shadows
									else if (choice == B || choice == "b")
									{
										staff_equiped = true;
										Class_Name = "Shadow Mage";
										type = 1.3;
										Console.WriteLine("As a shadow mage you can  bend shadows to your will");
										Console.WriteLine("Also if the will of your enemy is weak you can take controle of their shadow to have them fight for you");
										Console.WriteLine("Take heed though as a shadow mage creatures from the darkness will try to cross the barrier of their world");
										Console.WriteLine("they will try to drag you into the darkness");
										Console.WriteLine("so stand strong and dont die...");
										Thread.Sleep(1000);
										Console.WriteLine("or else");
										Console.ReadLine();
										Console.Clear();
										break;
									}
									#endregion
									#region Storm
									else if (choice == C || choice == "c")
									{
										staff_equiped = true;
										Class_Name = "Storm Mage";
										type = 1.4;
										Console.WriteLine("You have choosen the storm mage class");
										Console.WriteLine("as a storm mage you can manipulate the wind and conrole lightning");
										Console.WriteLine("your magic is more powerful during rain and thunder storms");
										Console.WriteLine("storm magic can be very powerful if used correctly");
										break;
									}
									#endregion
									#region Death
									else if (choice == D || choice == "d")
									{
										staff_equiped = true;
										Class_Name = "Necromancer";
										type = 1.5;
										Console.WriteLine("You have choosen the necromancer class");
										Console.WriteLine("as a necromancer you have control over the dead");
										Console.WriteLine("your magic is strongest when you are in grave yards and at night");
										Console.WriteLine("the creatures you raise to fight for you will however be weaker than their living forms");
										Console.WriteLine("also you cannot control the undead raised to fight against you");
										break;
									}
									#endregion
									#region Change
									else if (choice == E || choice == "e")
									{
										staff_equiped = true;
										Class_Name = "Transformation Mage";
										type = 1.6;
										Console.WriteLine("You have choosen the Transformation class");
										Console.WriteLine("as a trasformation mage you have the ability to morph yourself into a multitude of creatures");
										Console.WriteLine("however in order for you to transform into other creatures you must first defeat it");
										Console.WriteLine("you will be starting with one transformation as a wolf");
										break;
									}
									#endregion
									else if (choice == F || choice == "f")
									{
										break;
									}
									else
									{
										Console.Clear();
										Console.WriteLine("please enter valid option (enter letter and is case sensitive)");
										Console.ReadLine();
										Console.Clear();
									}
								}
								if (choice == A || choice == "a" || choice == B || choice == "b" || choice == C || choice == "c" || choice == D || choice == "d" || choice == E || choice == "e")
								{
									break;
								}

							}
							#endregion
							#region Knight
							else if (choice == B)
							{
								sword_equiped = true;
								Class_Name = "Knight";
								type = 2;
								Console.Clear();
								Console.WriteLine("You have chosen the Knight class");
								Console.WriteLine("As a knight you have a strong resistence to all forms of physical damage");
								Console.WriteLine("you also gain strong physical attack stats");
								Console.WriteLine("You will however be starting with a weak defence to magic");
								break;
							}
							#endregion
							#region Cleric
							else if (choice == C)
							{
								mace_equiped = true;
								staff_equiped = true;
								Class_Name = "Cleric";
								type = 3;
								Console.Clear();
								Console.WriteLine("You have chosen the Cleric class");
								Console.WriteLine("As a cleric you have the ability to channel higher powers to use healing spells");
								Console.WriteLine("You can also use a wide veriety of curses ");
								Console.WriteLine("you have a low resistence to magic and physical damage so be careful");
								break;
							}
							#endregion
							#region Bandit
							else if (choice == D)
							{
								dagger_equiped = true;
								Class_Name = "Bandit";
								type = 4;
								Console.Clear();
								Console.WriteLine("You have chosen the Bandit class");
								Console.WriteLine("As a bandit you have access to a small veriety of unique items such as smoke bombs and intreaging traps");
								Console.WriteLine("you have a moderate resistance to physical attacks but a very low resistence to magic");
								Console.WriteLine("The unique ability of your class is that when you kill an enemy you are more likely to get a rare item");
								break;
							}
							#endregion
							#region Assassin
							else if (choice == E)
							{
								dagger_equiped = true;
								Class_Name = "Assassin";
								type = 5;
								Console.Clear();
								Console.WriteLine("You have chosen the Assassin class");
								Console.WriteLine("As an assassin you wait hiding in the shadows for your prey to come to you");
								Console.WriteLine("then you attack with a hard hitting first strike");
								Console.WriteLine("you are able to have very precise strikes meaning you are more likly to get more of a dropped item then the other classes");
								Console.WriteLine("you will have a low resistance to physical attacks and a moderate resistence to magic attacks");
								break;
							}
							#endregion
							#region Swordsman
							else if (choice == F)
							{
								sword_equiped = true;
								Class_Name = "Swordsman";
								type = 6;
								Console.Clear();
								Console.WriteLine("You have chosen the Swordsmen class");
								Console.WriteLine("As a swordsman you have a mastery of the art of swordsmanship such as a knight ");
								Console.WriteLine("but you are not bound to serve anyone other than yourself");
								Console.WriteLine("you are resistante to all forms of damage but the damage can collect over time so watch how much damage you are taking");
								break;
							}
							#endregion
							#endregion
							#region WIP
							#region Theif
							else if (choice == G)
							{
								mace_equiped = true;
								dagger_equiped = true;
								Class_Name = "Theif";
								type = 7;
								Console.Clear();
								Console.WriteLine("You have chosen the Theif class");
								Console.WriteLine("As a theif you can slip into the shadows to get the one thing you want cash");
								Console.WriteLine("when you defeat an enemy they will drop more cash for you to spend upgrading");
								Console.WriteLine("You have a low resistence to all forms of damage");
								break;
							}
							#endregion
							#region Meme
							else if (choice == H)
							{
								mace_equiped = true;
								Class_Name = "Meme";
								type = 8;
								Console.Clear();
								Console.WriteLine("You have chosen the Meme class");
								Console.WriteLine("Well this is awkward");
								Thread.Sleep(900);
								Console.WriteLine("I wasn't expecting anyone to choose this class so...");
								Console.WriteLine("lets just say you win congradulations");
								Console.WriteLine("Good-Bye");
								break;
							}
							#endregion
							#region See Nothing
							else if (choice == I)
							{
								dagger_equiped = true;
								Class_Name = "Illuminati";
								type = 9;
								Console.Clear();
								Console.WriteLine("You have chosen the Illuminati class");
								Console.WriteLine("Well come my dear illuminati agent");
								Console.WriteLine("you will have the ability to kill any one none boss enemy in exchange for 30 cash");
								Console.WriteLine("you will have only a moderate Resistence to all damage as to balance out your very powerful ability");
								break;
							}
							#endregion
							#region Youtube
							else if (choice == J)
							{
								sword_equiped = true;
								Class_Name = "Youtuber";
								type = 10;
								Console.Clear();
								Console.WriteLine("You have chosen the Youtuber class");
								Console.WriteLine("As a youtuber you can amass your fans as an army to fight for you");
								Console.WriteLine("Your fans will however be easy to dispatch when not given any orders as to what they need to do");
								Console.WriteLine("Also some may get bored with you and leave");
								Console.WriteLine("will  you stay famous of die abandonded we will see");
								break;
							}
							#endregion
							#region Baker
							else if (choice == K)
							{
								dagger_equiped = true;
								staff_equiped = true;
								Class_Name = "Mr. Baker";
								type = 11;
								Console.Clear();
								Console.WriteLine("You have chosen the Mr. Baker class");
								Console.WriteLine("Welcome to the game as one of the two Teacher classes");
								Console.WriteLine("You will have the ability to charm any creature to fight for you but it isnt a perminate effect so be careful of who is your enemy and who is your friend");
								Console.WriteLine("Also you have a high Defence because of your silver tonge");
								break;
							}
							#endregion
							#region Dodak
							else if (choice == L)
							{
								sword_equiped = true;
								Class_Name = "Mr. Dodak";
								type = 12;
								Console.Clear();
								Console.WriteLine("You have chosen the Mr. Dodak class");
								Console.WriteLine("Welcome to the game as one of the two Teacher classes");
								Console.WriteLine("You will have the ability to bend the game world to your will and to completly remove enemies from existence");
								Console.WriteLine("Also you have a high Defence because nothing in the game world can touch you unless you let it");
								break;
							}
							#endregion
							#region Blank Slate
							else if (choice == M)
							{
								Class_Name = "Blank Slate";
								type = 13;
								Console.Clear();
								Console.WriteLine("you have choosen the Blank Slate class");
								Console.WriteLine("Because of this desion your character will not have any specific designated abilities or specialties");
								Console.WriteLine("it is up to you as to how this character will develope");
								Console.WriteLine("but just to be nice I will give you 100 cash to start of with");
								cash = cash + 100;
								break;
							}
							#endregion
							#region Fire Break
							else if (choice == "Fire Break")
							{
								Console.Clear();
								Console.WriteLine("umbram tuam, et reges prope");
								Console.WriteLine("sidera excitat in animis vestris et draconem");
								Console.WriteLine("verum in luce veritatis tuae mentis cum habebit in manu tua virtus et scientia");
								Console.WriteLine("vide quid sit veritas, quid te futurum");
								Console.WriteLine();
								Console.WriteLine("qui et te et accipies?");
								Console.WriteLine();
								Console.WriteLine("Etiam");
								Console.WriteLine("nihil");
								choice = Console.ReadLine();
								Console.Clear();
								if (choice == "Etiam")
								{
									staff_equiped = true;
									sword_equiped = true;
									type = 14.1;
									Class_Name = "Awakened Truth";
									Console.Clear();
									Console.WriteLine("May you find the truth you seek with ancient knowledge");
									Console.ReadLine();
									break;
								}
								else if (choice == "nihil")
								{
									sword_equiped = true;
									dagger_equiped = true;
									Class_Name = "Sleeping Darkness";
									type = 14.2;
									Console.Clear();
									Console.WriteLine("You will know your fate soon enough");
									Console.ReadLine();
									break;
								}
								else
								{
									dagger_equiped = true;
									type = 14.3;
									Class_Name = "Time's Secret";
									Console.Clear();
									Console.WriteLine("You are not ready for this fate");
									Console.WriteLine("May time eventually unlock your destiny");
									Console.ReadLine();
									break;
								}

							}
							#endregion
							#endregion
							#region Admin access
							else if (choice == "system: admin access")
							{
								Console.WriteLine("please enter admin password");
								string password = Console.ReadLine();
								Console.Clear();
								if (password == "shadow slayer")
								{
									adminAccess = true;
									Console.WriteLine("would you like full game access?(y/n)");
									choice = Console.ReadLine();
									Console.Clear();
									if (choice == y || choice == "Y")
									{
										Console.WriteLine("full game access granted");
										full_game = true;
									}
									else
									{
										Console.WriteLine("very well enjoy your time playing admin");
									}
								}
								else
								{
									Console.WriteLine("Access Denied");
								}
							}
							#endregion
							else
							{
								Console.Clear();
								Console.WriteLine("Please choose the letter of a valid class (letter must be capitalized)");
								Console.ReadLine();
								Console.Clear();
								continue;
							}
						}
						Console.WriteLine("now lets go on an adventure");
						Console.ReadLine();
					}
					#endregion
					#region Class Setting
					int[] staff = new int[10] { 10, 15, 20, 25, 30, 35, 40, 45, 50, 55 };
					int[] sword = new int[10] { 10, 15, 20, 25, 30, 35, 40, 45, 50, 55 };
					int[] mace = new int[10] { 7, 16, 25, 34, 43, 52, 61, 70, 79, 88 };
					int[] dagger = new int[10] { 5, 7, 9, 11, 13, 15, 17, 19, 21, 50 };
					int[] armour = new int[] { };
					int magAtk = baseMagAttach;
					int Hp = baseHealth;
					int phyAtk = basePhyAttack;
					int magDef = basemagDef;
					int phyDef = basephyDef;
					int coin = cash;
					if (type == 1.1)
					{
						magAtk = magAtk + 10 + staff[0];
						magDef = magDef + 10;
						phyAtk = 5;
						phyDef = 15;
					}
					else if (type == 1.2)
					{
						magAtk = magAtk + 5 + staff[0];
						magDef = magDef + 10;
						phyAtk = 7;
						phyDef = 15;
					}
					else if (type == 1.3)
					{
						magAtk = magAtk + 6 + staff[0];
						magDef = magDef + 15;
						phyAtk = 5;
						phyDef = 10;
					}
					else if (type == 1.4)
					{
						magAtk = magAtk + 3 + staff[0];
						magDef = magDef + 10;
						phyAtk = 5;
						phyDef = 15;
					}
					else if (type == 1.5)
					{
						magAtk = magAtk + 8 + staff[0];
						magDef = magDef + 10;
						phyAtk = 5;
						phyDef = 15;
					}
					else if (type == 1.6)
					{
						magAtk = magAtk + 2 + staff[0];
						magDef = magDef + 10;
						phyAtk = 15;
						phyDef = 20;
					}
					else if (type == 2)
					{
						magAtk = 0;
						magDef = 5;
						phyAtk = sword[0];
						phyDef = 35;
					}
					else if (type == 3)
					{
						magAtk = staff[1];
						magDef = 10;
						phyAtk = mace[0];
						phyDef = 10;
					}
					else if (type == 4)
					{
						magAtk = 0;
						magDef = 3;
						phyAtk = mace[0];
						phyDef = 30;
					}
					else if (type == 5)
					{
						magAtk = 5;
						magDef = 15;
						phyAtk = dagger[0];
						phyDef = 5;
					}
					else if (type == 6)
					{
						magAtk = 10;
						magDef = 20;
						phyAtk = sword[1];
						phyDef = 20;
					}
					else if (type == 7)
					{
						magAtk = 5;
						magDef = 5;
						phyAtk = dagger[1];
						phyDef = 5;
					}
					else if (type == 9)
					{
						magAtk = staff[0];
						magDef = 15;
						phyAtk = sword[0];
						phyDef = 15;
					}
					else if (type == 10)
					{
						magAtk = 40;
						magDef = 40;
						phyAtk = 40;
						phyDef = 40;
					}
					else if (type == 11)
					{
						magAtk = 10;
						magDef = 20;
						phyAtk = 10;
						phyDef = 20;
					}
					else if (type == 12)
					{
						magAtk = 30;
						magDef = 15;
						phyAtk = 5;
						phyDef = 20;
					}
					else if (type == 13)
					{
						magAtk = 0;
						magDef = 5;
						phyAtk = 5;
						phyDef = 5;
					}
					else if (type == 14.1)
					{
						magAtk = 30;
						magDef = 25;
						phyAtk = 20;
						phyDef = 25;
					}
					else if (type == 14.2)
					{
						magAtk = 15;
						magDef = 10;
						phyAtk = 10;
						phyDef = 15;
					}
					else if (type == 14.3)
					{
						magAtk = 10;
						magDef = 10;
						phyAtk = 10;
						phyDef = 10;
					}
					#endregion
					#region Creature making
					string[] FlameCreature_names = new string[20] { "fire imp", "ash wolf", "Black Flame Shade", "Molten Golem", "Magma Serpent", "Scorched Knight", "Obsidian Scorpion", "Rage Demon", "Enraged Shaman", "Banshee of The Dark Flame", "Corrupted Fire Spirit", "Hunter of the Burnt Ruin", "Prince of the Burning Kingdom", "Blazing Goblin", "Terrifing Bunny of The Pit", "Tormented Soul", "Ash Storm Dragon", "Flames of Chaos", "Cinder Winged Horror", "Flame Clawed Drake" };
					int[] FlameCreature_Health = new int[20] { 125, 150, 240, 315, 384, 500, 300, 632, 260, 547, 482, 290, 349, 520, 800, 394, 930, 656, 845, 937 };
					string[] FlameCreature_Type = new string[20] { "Demon", "Beast", "Shade", "Construct", "Serpent", "Human", "Beast", "Demon", "Human", "Spirit", "Spirit", "Human", "Human", "Beast", "Demon", "Spirit", "Dragon", "Demon", "Dragon", "Dragon" };
					string[] FlameMiniBoss_names = new string[] {"Eternal Flame Knights", "Fire God Enracu"};
					int[] FlameMiniBoss_health = new int[] {3000, 24300};
					string[] FlameMiniBoss_type = new string[] {"Human", "God"};
					string FlameCreature_BossName = "Hasharida, Herald of Fire";
					int FlameCreature_BossHealth = 4740;
					string FlameCreature_BossType = "Construct";
					bool FlameCreature_BossDefeated = false;
					string[] EarthCreature_names = new string[20] { "Terror of The Deep", "Wall Crawler", "Ancient Forge Assistant", "Mad man's Puzzle Cube", "Phantom Architect", "Sentient Dynamite", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
					int[] EarthCreature_health = new int[] {380, 130, 100, 220, 260, 400 };
					string[] EarthCreature_Type = new string[20] { "Demon-Beast", "Construct", "Human", "Construct", "Spirit", "Construct", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
					string[] EarthMiniBoss_names = new string[] {"True Forge Master", "Demon of The Forge", "Mountain God"};
					int[] EarthMiniBoss_health = new int[] {780, 830, 14400};
					string[] EarthMiniBoss_type = new string[] {"Human", "Demon", "God"};
					string EarthCreature_BossName = "Terashin, Lord of The Deep";
					int EarthCreature_BossHealth = 3500;
					string EarthCreature_BossType = "Beast";
					bool EarthCreature_BossDefeated = false;
					string[] WaterCreature_names = new string[20] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
					int[] WaterCreature_health = new int[] { };
					string[] WaterCreature_Type = new string[20] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
					string[] WaterMiniBoss_names = new string[] {"Sea God Friga", "Shrigin, the Deep Lurker"};
					int[] WaterMiniBoss_health = new int[] {613540, 48527};
					string[] WaterMiniBoss_type = new string[] {"God", "Beast"};
					string WaterCreature_BossName = "Astriqa, Acient Leviathon";
					int WaterCreature_BossHealth = 3795;
					string WaterCreature_BossType = "Serpent";
					bool WaterCreature_BossDefeated = false;
					string[] AirCreature_names = new string[20] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
					int[] AirCreature_health = new int[] { };
					string[] AirCreature_Type = new string[20] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
					string[] AirMiniBoss_names = new string[] {"Neratie, Godess of Wind", };
					int[] AirMiniBoss_health = new int[] {52130, };
					string[] AirMiniBoss_type = new string[] {"God", };
					string AirCreature_BossName = "Caelumanura, Ruler of the Stars";
					int AirCreature_BossHealth = 7140;
					string AirCreature_BossType = "Dragon";
					bool AirCreature_BossDefeated = false;
					string[] WasteCreature_names = new string[20] { "Mind Warper", "Corupting Mist", "Heart Eater", "Dunwitch Horror", "Dream Stalker", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
					int[] WasteCreature_health = new int[] {680, 732, 893, 5671, 7362};
					string[] WasteCreature_Type = new string[20] { "Unknown", "Unknown", "Unknown", "Unknown", "Unknown", "Unknown", "Unknown", "Unknown", "Unknown", "Unknown", "Unknown", "Unknown", "Unknown", "Unknown", "Unknown", "Unknown", "Unknown", "Unknown", "Unknown", "Unknown" };
					string[] WasteMiniBoss_names = new string[] {"Blade of Eternal Chaos"};
					int[] WasteMiniBoss_health = new int[] {13846};
					string[] WasteMiniBoss_type = new string[] {"Construct"};
					string WasteCreature_BossName = "Iteath, Bringer of Chaos";
					int WasteCreature_BossHealth = 873600;
					string WasteCreature_BossType = "Human";
					bool WasteCreature_BossDefeated = false;
					string[] ShadowCreature_names = new string[20] { "Twisted Shadows", "Kingdom Gaurd", "Weaver of Shadows", "Darkness Walker", "Risen Drake", "Lurking Shade", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
					int[] ShadowCreature_health = new int[] {438, 382, 670, 516, 590, 465 };
					string[] ShadowCreature_Type = new string[20] { "Abomination", "Human", "Human", "Shadow", "Undead", "Spirit", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
					string[] ShadowMiniBoss_names = new string[] { "Haster, the Exiled God", "Arcien, the Shadow General", "Malum, Heart of Darkness"};
					int[] ShadowMiniBoss_health = new int[] { 17850, 1780, 2300};
					string[] ShadowMiniBoss_type = new string[] { "God" , "Human", "Demon"};
					string ShadowCreature_BossName = "Nerash, Eternity's Devourer";
					int Shadowture_BossHealth = 8590;
					string ShadowCreature_BossType = "Unkown";
					bool ShadowCreature_BossDefeated = false;
					string[] BossCreature_names = new string[] { "", "" };
					int[] BossCreature_health = new int[] { };
					string[] DungeonCreature_names = new string[] { };
					int[] DungeonCreature_health = new int[] { };
					string FinalBoss;
					int finalboss_health;
					#endregion
					#region Program later
					//this area is for programming weapons, armour, enemies, and more with unique effects, for the player and npcs, that are long lasting but can only have one of each in the game. They also have to be rare to appear or very difficult to be found.
					#region Unique Weapons
					#endregion
					#region Unique Effects
					#endregion
					#region Unique Enemies
					#endregion
					#endregion
					#region main game
					#region skill set
					int healthPoints = 3;
					int endurence = 4;
					int vitility = 3;
					int strength = 2;
					int intelegence = 3;
					int faith = 3;
					int armourEfficentcy = 1;
					int spcResistence = 2;
					#endregion
					#region all stats
					int levelPerks = 0;
					int zentos = 1;
					bool left_enabled = false;
					string remove;
					bool unarmed = false;
					int cheats_used = 0;
					double level = 1;
					int maxHp = Hp;
					int maxMg = magic_Energy;
					int maxSt = stamina;
					int[] buyingSwordDamage = new int[] { 20, 35, 48, 64, 82 };  //iron, steel, shadow's bane, Beast King, Demon iron
					int[] buyingStaffDamage = new int[] { 30, 42, 50, 62, 78 };
					List<int> inventoryNums = new List<int>();
					List<string> Items = new List<string>();
					List<string> Potions = new List<string>();
					List<string> Armour = new List<string>();
					List<int> ArmourDefence = new List<int>();
					List<string> ArmourType = new List<string>();
					List<string> ArmourEnchantment = new List<string>();
					List<string> Weapons = new List<string>();
					List<int> WeaponDamage = new List<int>();
					List<string> WeaponType = new List<string>();
					List<string> WeaponEnchantment = new List<string>();
					List<int> Items_Price = new List<int>();
					List<bool> Bought_Item = new List<bool>();
					List<string> Magic = new List<string>();
					List<int> MagicDamage = new List<int>();
					List<string> MagicType = new List<string>();
					List<int> MagicCost = new List<int>();
					List<string> remnantMagic = new List<string>();
					string current_enemy;
					int current_attack = 0;
					double current_defence = 0;
					bool Home = false;
					bool item = false;
					bool buy = false;
					int finalWarning = 0;
					string rightHandWeaponEquiped = "";
					string leftHandWeaponEquiped = "";
					int rightHandWeaponStats;
					int leftHandWeaponStats;
					string EquipedArmour;
					int EquipedArmourStats;
					string EquipedArmourType;
					int Dungeon_clear = 0;
					int staff_level = 1;
					int gold = 0;
					int macez = 10;
					int swordz = 20;
					int staffz = 10;
					int daggerz = 10;
					Hp = 70;
					int t = 0;
					int r = 0;
					int z;
					int por;
					bool left = false;
					bool buy1 = false;
					bool buy2 = false;
					bool buy3 = false;
					bool buy4 = false;
					string shop_stat = "open";
					string shop_option = "three";
					#endregion
					#region attacks
					string[] magicAttacks = new string[] { "Time crack", "After Image", "Split Existence", "Temporal Break", "Burning Seal", "Fire Cut", "Ignite", "Flash Flame", "Shadow Bend", "Shadow Kingdom", "Shade Cloak", "Enveloping Darkness", "lightning strike", "Summon Storm", "Electric shock", "Magnetic Charge", "Breath of Death", "Manipulate Corpse", "Revert Dead", "Broken cycle", "Become Beast", "Copy Creature", "Alter Soul", "Location Alteration", "Power Blast", "Aura of Protection", "Enchanted Blade", "Cloak of Health" };//0-3 Time, 4-7 Pyromancy, 8-11 Shadow, 12-15 storm, 16-19 necromancy, 20-23 Transform, 24-27 Default Magic
					int[] magicDamage = new int[] { 25, 0, 40, 30, 20, 34, 10, 1, 5, 17, 0, 21, 31, 1, 15, 0, 30, 13, 27, 17, 0, 0, 12, 0, 14, 0, 10, 2 };
					string[] physicalAttack = new string[] { "Blinding Slash", "Cripling strike", "Hilt Stike", "Frenzy Cut", "Crushing Blow", "Armour Crush", "Knee Break", "Shatter Skull", "Hidden Strike", "Frontal Attack", "Sudden Strike", "Posioned Strike", "Upper cut", "Sucker punch", "Round house kick", "Furrious fist" }; //0-3 Sword, 4-7 Mace, 8-11 Dagger, 12-15 Unarmed
					int[] physicalDamage = new int[] { };
					List<string> attackOptions = new List<string> { "none", "none", "none", " none" };
					List<int> attackDamage = new List<int> { 0, 0, 0, 0 };
					#endregion
					#region Random Setup
					Random creatureRand = new Random();
					Random dropRand = new Random();
					Random encounter = new Random();
					Random success = new Random(); // for use with shadow kingdom spell
					#endregion
					#region Item Add
					Weapons.Add("Iron Sword");
					WeaponDamage.Add(14);
					WeaponType.Add("Sword");
					WeaponEnchantment.Add("None");
					Armour.Add("Iron Armour");
					ArmourDefence.Add(20);
					ArmourType.Add("Armour");
					ArmourEnchantment.Add("None");
					Armour.Add("Leather Shield");
					ArmourDefence.Add(10);
					ArmourType.Add("Shield");
					ArmourEnchantment.Add("None");
					Weapons.Add("Iron Mace");
					WeaponDamage.Add(17);
					WeaponType.Add("Mace");
					WeaponEnchantment.Add("None");
					Weapons.Add("Flaming Bow");
					WeaponDamage.Add(10);
					WeaponType.Add("Bow");
					WeaponEnchantment.Add("Fire");
					Armour.Add("Gaurdians Shield");
					ArmourDefence.Add(20);
					ArmourType.Add("Sheild");
					ArmourEnchantment.Add("Encomposing Ward");
					#endregion
					#region Magic Add
					Magic.Add("Dark Flame");//fire
					MagicDamage.Add(15);
					MagicCost.Add(10);
					MagicType.Add("Pyromancy");
					remnantMagic.Add("Scorch");
					Magic.Add("Return To Order");//order
					MagicDamage.Add(13);
					MagicCost.Add(15);
					MagicType.Add("Order");
					remnantMagic.Add("none");
					Magic.Add("Chaotic Destruction");//chaos
					MagicDamage.Add(18);
					MagicCost.Add(17);
					MagicType.Add("Chaos");
					remnantMagic.Add("none");
					Magic.Add("Risen Army");//dead
					MagicDamage.Add(13);
					MagicCost.Add(14);
					MagicType.Add("Necromancy");
					remnantMagic.Add("none");
					Magic.Add("Flash Freeze");//ice
					MagicDamage.Add(15);
					MagicCost.Add(10);
					MagicType.Add("Cryomancy");
					remnantMagic.Add("Slowed");
					Magic.Add("Burst Flame");//fire
					MagicDamage.Add(19);
					MagicCost.Add(4);
					MagicType.Add("Pyromancy");
					remnantMagic.Add("Scorch");
					Magic.Add("Consuming Void");
					MagicDamage.Add(17);
					MagicCost.Add(16);
					MagicType.Add("Void");
					remnantMagic.Add("none");
					#endregion
					while (Hp > 0)
					{
						Console.Clear();
						Console.WriteLine("NOTICE: Game is a work in progress so some areas are in accessable and some machanics dont function fully");
						Console.WriteLine("Welcome to the world of adventures and monsters");
						Console.WriteLine("in this world there is no set path");
						Console.WriteLine("you must decide how this world unfolds");
						Console.WriteLine("so where will you go?");
						Console.WriteLine();
						Console.WriteLine("A. Creature Fields (WIP)");
						Console.WriteLine("B. Dark Dungeon");
						Console.WriteLine("C. Town");
						Console.WriteLine("D. Stats");
						if (Home == true)
						{
							Console.WriteLine("E. Go to home");
							Console.WriteLine("F. Info on game world");
							Console.WriteLine("G. Inventory");
							Console.WriteLine("H. Magic");
						}
						if (Home == false)
						{
							Console.WriteLine("E. Info on game world");
							Console.WriteLine("F. Inventory");
							Console.WriteLine("G. Magic");
						}
						choice = Console.ReadLine();
						Console.Clear();
						#region Creature_Fields
						if (choice == A || choice == "a")
						{
							if (full_game == true)
							{
								Console.WriteLine("Welcome to the creature fields");
								Console.WriteLine("Here you will encounter many creatures of all shapes, sizes and levels");
								Console.WriteLine("Be careful though darkness has been looming over some areas of the fields");
								Thread.Sleep(5000);
								Console.Clear();
								Console.WriteLine("Which area of the creature fields would you like to travel to?");
								Console.WriteLine();
								Console.WriteLine("A. Burning Plains");
								Console.WriteLine("B. Drake Mine");
								Console.WriteLine("C. Broken Sky Peak");
								Console.WriteLine("D. Withering Swamps");
								Console.WriteLine("E. Shattered Wasteland (WARNING: HIGH LEVEL CREATURES LOCATED HERE [suggested level: 20+] )");
								choice = Console.ReadLine();
								Console.Clear();
								if (choice == A || choice == "a") //Burning Planes
								{
									int flameGate = creatureRand.Next(FlameCreature_names.Length);
									int currentCreature = FlameCreature_Health[flameGate];
									while (FlameCreature_Health[flameGate] > 0 || Hp > 0)
									{
										Console.WriteLine(FlameCreature_names[flameGate]);
										Console.WriteLine("enemy health: " + currentCreature * (level * 1.23));
									}
								}
								else if (choice == B || choice == "b") //Drake Mines
								{
									int earthGate = creatureRand.Next(EarthCreature_names.Length);
								}
							}
							else if (full_game == false)
							{
								Console.WriteLine("I am sorry but this area is currently still being designed");
								Console.ReadLine();
							}
						}

						#endregion
						#region dungeons
						else if (choice == B || choice == "b")
						{
							if (Dungeon_clear == 0)
							{
								Console.WriteLine("welcome traveler as this is your first time atempting to clear a dungeon");
								Console.WriteLine("I just wanted to warn you that the dungeons are full of powerful and unique creatures, with a powerful boss at the end of each");
								Console.WriteLine("You will not be allowed to leave a dungeon once you enter it until it has been cleared");
								Console.WriteLine();
								Console.WriteLine("note: some dungeons have tests in them as well as creatures so choose carefully");
								Console.WriteLine();
							}
							Console.WriteLine("Three Dungeons are avalible to you at a time");
							Console.WriteLine("Which would you like to test your stength and knowledge in? (underconstruction)");
							Console.WriteLine();
							Console.WriteLine("A. Shadow Flame");
							if (full_game == true)
							{
								Console.WriteLine("B. Madness of the Deep Eath");
								Console.WriteLine("C. Relentless Knowledge");
							}
							choice = Console.ReadLine();
							Console.Clear();
							int x = 0;
							#region Shadow Flame
							if (choice == A || choice == "a")
							{
								Console.WriteLine("You have entered the The Shadow Flame dungeon");
								Console.WriteLine("This dungeon exists in the relm of shadows and darkness");
								Console.WriteLine("You must find your way to the end chamber in order to escape");
								Console.WriteLine("you start the treck to clear the dungeon");
								int alpha = 10;
								while (alpha > 0)
								{
									int zeta = rand.Next(0, creatures.Count());
									current_enemy = creatures[zeta];
									current_defence = 5;
									current_attack = 5;
									int current_health = 5;
									while (current_health > 0)
									{
										Console.WriteLine("you walk through the dungeon when you suddenly encounter a " + current_enemy);
										Console.WriteLine("Level: " + level);
										Console.WriteLine("Hp: " + Hp);
										Console.WriteLine("stamina: " + stamina);
										Console.WriteLine("magicka: " + magic_Energy);
										Console.WriteLine("Gold: " + gold);
										Console.WriteLine();
										Console.WriteLine();
										Console.WriteLine("A. Attack");
										Console.WriteLine("B. Potion");
										Console.WriteLine("C. Change Weapon");
										Console.WriteLine();
										choice = Console.ReadLine();
										Console.Clear();
										if (choice == A || choice == "a")
										{
											Console.WriteLine("Attack options:");
											int zer;
											if (type == 1.1 || sword_equiped == true)
											{
												zer = 0;
											}
											else if (type == 1.2 || mace_equiped == true)
											{
												zer = 1;
											}
											else if (type == 1.3 || dagger_equiped == true)
											{
												zer = 2;
											}
											else if (type == 1.4 || unarmed == true)
											{
												zer = 3;
											}
											else if (type == 1.5)
											{
												zer = 4;
											}
											else if (type == 1.6)
											{
												zer = 5;
											}
											else
											{
												zer = 6;
											}
											int ret = 0;
											int req = 0;
											int rew = 1;
											req = zer * 4;
											while (ret < 4)
											{

												if (sword_equiped == true || dagger_equiped == true || mace_equiped == true || unarmed == true)
												{
													Console.WriteLine(rew + ". " + physicalAttack[req]);
													attackOptions[ret] = physicalAttack[req];
													attackDamage[ret] = physicalDamage[req];
													rew++;
													req++;
													ret++;
												}
												else
												{
													Console.WriteLine(rew + ". " + magicAttacks[req]);
													attackOptions[ret] = magicAttacks[req];
													attackDamage[ret] = magicDamage[req];
													rew++;
													req++;
													ret++;
												}
											}
											choice = Console.ReadLine();
											if (choice == "System: Return" || choice == "system: return")
											{
												Console.Clear();
												Console.WriteLine("returning to main menu");
												Thread.Sleep(2000);
												break;
											}
											else
											{
												int ren = Convert.ToInt32(choice);
												ren--;
												string damageName = attackOptions[ren];
												int damageAmount = attackDamage[ren];
											}
										}
										else if (choice == B || choice == "b") //potion use
										{
											z = 0;
											por = 1;
											Console.WriteLine("Potions:");
											while (z < Potions.Count)
											{
												Console.WriteLine(por + ". " + Potions[z]);
												z++;
												por++;
											}
											Console.WriteLine("To go cancel potion selection just tape enter with a blank bar");
											choice = Console.ReadLine();
											Console.Clear();
											int ter = Convert.ToInt32(choice);
											if (ter <= Potions.Count && ter > 0)
											{

												ter--;
												if (ter <= Potions.Count)
												{
													if (Potions[ter] == "Potion of Health")
													{
														Console.WriteLine("You have restored your health");
														Hp = maxHp;
														Potions.RemoveAt(ter);
													}
													else if (Potions[ter] == "Potion of Stamina")
													{
														Console.WriteLine("You have restored your stamina");
														stamina = maxSt;
														Potions.RemoveAt(ter);
													}
													else if (Potions[ter] == "Potion of Magic")
													{
														Console.WriteLine("You have restored your Magicka");
														magic_Energy = maxMg;
														Potions.RemoveAt(ter);
													}
													Thread.Sleep(1500);
												}
											}
											else if (choice == "Back" || choice == "back")
											{
												continue;
											}
											else
											{
												Console.WriteLine("please enter valid number");
											}
										}
										else if (choice == C || choice == "c") //change weapons
										{
											z = 0;
											por = 1;
											Console.WriteLine("Right Hand Equipped Weapon: " + rightHandWeaponEquiped);
											if (leftHandWeaponEquiped != "")
											{
												Console.WriteLine("Left Hand Equipped Weapon: " + leftHandWeaponEquiped);
											}
											Console.WriteLine("Weapons:");
											while (z < Weapons.Count)
											{
												Console.WriteLine(por + ". " + Weapons[z]);
												z++;
												por++;
												if (Weapons.Count == 0)
												{
													Console.WriteLine("you have no avalible weapons to switch to");
												}
											}
											Console.WriteLine();
											Console.WriteLine("To return to previous menu type just tap enter with a blank bar");
											choice = Console.ReadLine();
											Console.Clear();
											if (rightHandWeaponEquiped != "" && left_enabled)
											{
												Console.WriteLine("Left hand or right hand");
												Console.WriteLine("A. Left");
												Console.WriteLine("B. Right");
												string hand = Console.ReadLine();
												if (hand == A || hand == "a")
												{
													left = true;
												}
											}
											int wz = Convert.ToInt32(choice);
											if (wz <= Weapons.Count && wz >= 1)
											{
												if (left == true)
												{
													wz = wz - 1;
													Weapons.Add(leftHandWeaponEquiped);
													remove = leftHandWeaponEquiped;
													leftHandWeaponEquiped = Weapons[wz];
													Weapons.RemoveAt(wz);
													if (remove == "")
													{
														Weapons.Remove("");
													}
												}
												wz = wz - 1;
												Weapons.Add(rightHandWeaponEquiped);
												remove = rightHandWeaponEquiped;
												rightHandWeaponEquiped = Weapons[wz];
												Weapons.RemoveAt(wz);
												if (remove == "")
												{
													Weapons.Remove("");
												}

											}
										}
									}
								}
							}
							#endregion
						}
						#endregion
						#region Town
						else if (choice == C || choice == "c")
						{
							while (true)
							{
								Console.WriteLine("There are " + shop_option + " shops currently open");
								Console.WriteLine();
								Console.WriteLine("A. Blacksmith");
								if (full_game == true)
								{
									Console.WriteLine("B. Alchemist shop");
									Console.WriteLine("C. Bed & Bar");
									if (shop_option == "four" || shop_option == "five")
									{
										Console.WriteLine("D. Housing market");
									}
									if (shop_option == "five")
									{
										Console.WriteLine("E. Enchanter");
									}
									if (shop_option == "four")
									{
										Console.WriteLine("E. Back");
									}
									else if (shop_option == "five")
									{
										Console.WriteLine("F. Back");
									}
									else
									{
										Console.WriteLine("D. Back");
									}
								}
								else
								{
									Console.WriteLine("B. Back");
								}
								Console.WriteLine();
								choice = Console.ReadLine();
								Console.Clear();
								#region BlackSmith
								if (choice == A || choice == "a")
								{
									while (true)
									{
										Console.Clear();
										Console.WriteLine("The Sleeping Dragon");
										Console.WriteLine();
										Console.WriteLine("meeting all your weapon and armour needs");
										Console.WriteLine("what do need?");
										Console.WriteLine();
										Console.WriteLine("A. Buy new weapon");
										Console.WriteLine("B. Improve Weapon");
										Console.WriteLine("C. Buy Armour");
										Console.WriteLine("D. Improve Armour");
										if (item == true)
										{
											Console.WriteLine("E. sell items");
											Console.WriteLine("F. back");
										}
										if (item == false)
										{
											Console.WriteLine("E. back");
										}
										choice = Console.ReadLine();
										Console.Clear();
										#region Buying Weapons
										int c3;
										if (choice == A || choice == "a")
										{
											while (true)
											{
												Console.WriteLine("What are you looking for?");
												Console.WriteLine();
												Console.WriteLine("A. sword");
												Console.WriteLine("B. staff");
												Console.WriteLine("C. dagger");
												Console.WriteLine("D. mace");
												Console.WriteLine("E. Back");
												choice = Console.ReadLine();
												Console.Clear();
												#region sword
												if (choice == A || choice == "a")
												{
													while (true)
													{
														Console.WriteLine("To gain acess to more swords level up");
														Console.WriteLine("What type of sword do you want?");
														Console.WriteLine();
														Console.WriteLine("A. Iron");
														Console.WriteLine("B. Steel");
														Console.WriteLine("C. Shadow's Bane");
														Console.WriteLine("D. Beast King");
														Console.WriteLine("E. Demon Iron");
														Console.WriteLine("F. Back");
														choice = Console.ReadLine();
														Console.Clear();
														if (choice == A || choice == "a")
														{
															while (true)
															{
																c3 = 0;
																if (buy == true)
																{
																	int itemPrice = 30;
																	Console.WriteLine("Weapon type: Iron Sword");
																	Console.WriteLine("Damage:" + buyingSwordDamage[c3] * (strength * 1.3));
																	Console.WriteLine("Price:" + itemPrice);
																	Console.WriteLine();
																	Console.WriteLine("Would you like to buy this sword?");
																	Console.WriteLine("A. Yes");
																	Console.WriteLine("B. No");
																	choice = Console.ReadLine();
																	Console.Clear();
																	if (choice == A && gold >= itemPrice || choice == "a" && gold >= itemPrice)
																	{
																		buy1 = true;
																		gold = gold - itemPrice;
																		Items.Add("Iron Sword");
																		Weapons.Add("Iron Sword");
																		break;
																	}
																	else if (choice == A && gold < itemPrice || choice == "a" & gold < itemPrice)
																	{
																		Console.WriteLine("you cannot afford this item");
																		Thread.Sleep(1500);
																		break;
																	}
																	else if (choice == B || choice == "b")
																	{
																		break;
																	}

																}
															}
															Console.Clear();
														}
														else if (choice == B || choice == "b")
														{
															while (true)
															{
																c3 = 1;
																if (buy == true)
																{
																	int itemPrice = 75;
																	Console.WriteLine("Weapon type: Steel Sword");
																	Console.WriteLine("Damage:" + buyingSwordDamage[c3] * (strength * 1.3));
																	Console.WriteLine("Price:" + itemPrice);
																	Console.WriteLine();
																	Console.WriteLine("Would you like to buy this sword?");
																	Console.WriteLine("A. Yes");
																	Console.WriteLine("B. No");
																	choice = Console.ReadLine();
																	Console.Clear();
																	if (choice == A && gold >= itemPrice || choice == "a" && gold >= itemPrice)
																	{
																		buy1 = true;
																		gold = gold - itemPrice;
																		Items.Add("Steel Sword");
																		Weapons.Add("Steel Sword");
																		break;
																	}
																	else if (choice == A && gold < itemPrice || choice == "a" & gold < itemPrice)
																	{
																		Console.WriteLine("you cannot afford this item");
																		Thread.Sleep(1500);
																		break;
																	}
																	else if (choice == B || choice == "b")
																	{
																		break;
																	}
																}
															}
														}
														else if (choice == C || choice == "c")
														{
															while (true)
															{
																c3 = 2;
																if (buy == true)
																{
																	int itemPrice = 150;
																	Console.WriteLine("Weapon type: Shadow's Bane");
																	Console.WriteLine("Damage:" + buyingSwordDamage[c3] * (strength * 1.3));
																	Console.WriteLine("Price:" + itemPrice);
																	Console.WriteLine();
																	Console.WriteLine("Would you like to buy this sword?");
																	Console.WriteLine("A. Yes");
																	Console.WriteLine("B. No");
																	choice = Console.ReadLine();
																	Console.Clear();
																	if (choice == A && gold >= itemPrice || choice == "a" && gold >= itemPrice)
																	{
																		buy1 = true;
																		gold = gold - itemPrice;
																		Items.Add("Shadow's Bane");
																		Weapons.Add("Shadow's Bane");
																		break;
																	}
																	else if (choice == A && gold < itemPrice || choice == "a" & gold < itemPrice)
																	{
																		Console.WriteLine("you cannot afford this item");
																		Thread.Sleep(1500);
																		break;
																	}
																	else if (choice == B || choice == "b")
																	{
																		break;
																	}
																}
															}
														}
														else if (choice == D || choice == "d")
														{
															while (true)
															{
																c3 = 3;
																if (buy == true)
																{
																	int itemPrice = 200;
																	Console.WriteLine("Weapon type: Beast King");
																	Console.WriteLine("Damage:" + buyingSwordDamage[c3] * (strength * 1.3));
																	Console.WriteLine("Price:" + itemPrice);
																	Console.WriteLine();
																	Console.WriteLine("Would you like to buy this sword?");
																	Console.WriteLine("A. Yes");
																	Console.WriteLine("B. No");
																	choice = Console.ReadLine();
																	Console.Clear();
																	if (choice == A && gold >= itemPrice || choice == "a" && gold >= itemPrice)
																	{
																		buy1 = true;
																		gold = gold - itemPrice;
																		Items.Add("Beast King");
																		Weapons.Add("Beast King");
																		break;
																	}
																	else if (choice == A && gold < itemPrice || choice == "a" & gold < itemPrice)
																	{
																		Console.WriteLine("you cannot afford this item");
																		Thread.Sleep(1500);
																		break;
																	}
																	else if (choice == B || choice == "b")
																	{
																		break;
																	}
																}
															}
														}
														else if (choice == E || choice == "e")
														{
															while (true)
															{
																c3 = 4;
																if (buy == true)
																{
																	int itemPrice = 300;
																	Console.WriteLine("Weapon type: Demon Iron");
																	Console.WriteLine("Damage:" + buyingSwordDamage[c3] * (strength * 1.3));
																	Console.WriteLine("Price:" + itemPrice);
																	Console.WriteLine();
																	Console.WriteLine("Would you like to buy this sword?");
																	Console.WriteLine("A. Yes");
																	Console.WriteLine("B. No");
																	choice = Console.ReadLine();
																	Console.Clear();
																	if (choice == A && gold >= itemPrice || choice == "a" && gold >= itemPrice)
																	{
																		buy1 = true;
																		gold = gold - itemPrice;
																		Items.Add("Demon Iron");
																		Weapons.Add("Demon Iron");
																		break;
																	}
																	else if (choice == A && gold < itemPrice || choice == "a" & gold < itemPrice)
																	{
																		Console.WriteLine("you cannot afford this item");
																		Thread.Sleep(1500);
																		break;
																	}
																	else if (choice == B || choice == "b")
																	{
																		break;
																	}
																}
															}
														}
														else if (choice == F || choice == "f")
														{
															break;
														}
													}
												}
												#endregion
												#region Staff
												else if (choice == B || choice == "b")
												{
													while (true)
													{
														Console.WriteLine("To gain acess to more staffs level up");
														Console.WriteLine("What type of staff do you want?");
														Console.WriteLine();
														Console.WriteLine("A. Ironwood");
														Console.WriteLine("B. Flaming Willow");
														Console.WriteLine("C. White Sycamore");
														Console.WriteLine("D. Silver Ash");
														Console.WriteLine("E. Shade Oak");
														Console.WriteLine("F. Back");
														choice = Console.ReadLine();
														Console.Clear();
														int c4;
														if (choice == A || choice == "a")
														{
															c4 = 0;
															while (true)
															{
																if (buy == true)
																{
																	int itemPrice = 30;
																	Console.WriteLine("Weapon type: Ironwood");
																	Console.WriteLine("Damage:" + buyingStaffDamage[c4] * (intelegence * 1.3));
																	Console.WriteLine("Price:" + itemPrice);
																	Console.WriteLine();
																	Console.WriteLine("Would you like to buy this staff?");
																	Console.WriteLine("A. Yes");
																	Console.WriteLine("B. No");
																	choice = Console.ReadLine();
																	Console.Clear();
																	if (choice == A && gold >= itemPrice || choice == "a" && gold >= itemPrice)
																	{
																		buy2 = true;
																		gold = gold - itemPrice;
																		Items.Add("Ironwood");
																		Weapons.Add("Ironwood");
																		break;
																	}
																	else if (choice == A && gold < itemPrice || choice == "a" & gold < itemPrice)
																	{
																		Console.WriteLine("you cannot afford this item");
																		Thread.Sleep(1500);
																		break;
																	}
																	else if (choice == B || choice == "b")
																	{
																		break;
																	}
																}
															}
															Console.Clear();
														}
														else if (choice == B || choice == "b")
														{
															c4 = 1;
															while (true)
															{
																if (buy == true)
																{
																	int itemPrice = 30;
																	Console.WriteLine("Weapon type: Flaming Willow");
																	Console.WriteLine("Damage:" + buyingStaffDamage[c4] * (intelegence * 1.3));
																	Console.WriteLine("Price:" + itemPrice);
																	Console.WriteLine();
																	Console.WriteLine("Would you like to buy this staff?");
																	Console.WriteLine("A. Yes");
																	Console.WriteLine("B. No");
																	choice = Console.ReadLine();
																	Console.Clear();
																	if (choice == A && gold >= itemPrice || choice == "a" && gold >= itemPrice)
																	{
																		buy2 = true;
																		gold = gold - itemPrice;
																		Items.Add("Flaming Willow");
																		Weapons.Add("Flaming Willow");
																		break;
																	}
																	else if (choice == A && gold < itemPrice || choice == "a" & gold < itemPrice)
																	{
																		Console.WriteLine("you cannot afford this item");
																		Thread.Sleep(1500);
																		break;
																	}
																	else if (choice == B || choice == "b")
																	{
																		break;
																	}
																}
															}
															Console.Clear();
														}
														else if (choice == C || choice == "c")
														{
															c4 = 2;
															while (true)
															{
																if (buy == true)
																{
																	int itemPrice = 30;
																	Console.WriteLine("Weapon type: White Sycamore");
																	Console.WriteLine("Damage:" + buyingStaffDamage[c4] * (intelegence * 1.3));
																	Console.WriteLine("Price:" + itemPrice);
																	Console.WriteLine();
																	Console.WriteLine("Would you like to buy this staff?");
																	Console.WriteLine("A. Yes");
																	Console.WriteLine("B. No");
																	choice = Console.ReadLine();
																	Console.Clear();
																	if (choice == A && gold >= itemPrice || choice == "a" && gold >= itemPrice)
																	{
																		buy2 = true;
																		gold = gold - itemPrice;
																		Items.Add("White Sycamore");
																		Weapons.Add("White Sycamore");
																		break;
																	}
																	else if (choice == A && gold < itemPrice || choice == "a" & gold < itemPrice)
																	{
																		Console.WriteLine("you cannot afford this item");
																		Thread.Sleep(1500);
																		break;
																	}
																	else if (choice == B || choice == "b")
																	{
																		break;
																	}
																}
															}
															Console.Clear();
														}
														else if (choice == D || choice == "d")
														{
															c4 = 3;
															while (true)
															{
																if (buy == true)
																{
																	int itemPrice = 30;
																	Console.WriteLine("Weapon type: Silver Ash");
																	Console.WriteLine("Damage:" + buyingStaffDamage[c4] * (intelegence * 1.3));
																	Console.WriteLine("Price:" + itemPrice);
																	Console.WriteLine();
																	Console.WriteLine("Would you like to buy this staff?");
																	Console.WriteLine("A. Yes");
																	Console.WriteLine("B. No");
																	choice = Console.ReadLine();
																	Console.Clear();
																	if (choice == A && gold >= itemPrice || choice == "a" && gold >= itemPrice)
																	{
																		buy2 = true;
																		gold = gold - itemPrice;
																		Items.Add("Silver Ash");
																		Weapons.Add("Silver Ash");
																		break;
																	}
																	else if (choice == A && gold < itemPrice || choice == "a" & gold < itemPrice)
																	{
																		Console.WriteLine("you cannot afford this item");
																		Thread.Sleep(1500);
																		break;
																	}
																	else if (choice == B || choice == "b")
																	{
																		break;
																	}
																}
															}
															Console.Clear();
														}

														else if (choice == E || choice == "e")
														{
															if (buy == true)
															{
																c4 = 1;
																while (true)
																{
																	if (buy == true)
																	{
																		int itemPrice = 30;
																		Console.WriteLine("Weapon type: Shade Oak");
																		Console.WriteLine("Damage:" + buyingStaffDamage[c4] * (intelegence * 1.3));
																		Console.WriteLine("Price:" + itemPrice);
																		Console.WriteLine();
																		Console.WriteLine("Would you like to buy this staff?");
																		Console.WriteLine("A. Yes");
																		Console.WriteLine("B. No");
																		choice = Console.ReadLine();
																		Console.Clear();
																		if (choice == A && gold >= itemPrice || choice == "a" && gold >= itemPrice)
																		{
																			buy2 = true;
																			gold = gold - itemPrice;
																			Items.Add("Shade Oak");
																			Weapons.Add("Shade Oak");
																			break;
																		}
																		else if (choice == A && gold < itemPrice || choice == "a" & gold < itemPrice)
																		{
																			Console.WriteLine("you cannot afford this item");
																			Thread.Sleep(1500);
																			break;
																		}
																		else if (choice == B || choice == "b")
																		{
																			break;
																		}
																	}
																}
																Console.Clear();
															}
														}
														else if (choice == F || choice == "f")
														{
															break;
														}
													}
												}
												#endregion
												#region dagger
												else if (choice == C || choice == "c")
												{
													Console.WriteLine("To gain acess to more daggers level up");
													Console.WriteLine("What type of dagger do you want?");
													Console.WriteLine();
													Console.WriteLine("A. Iron");
													Console.WriteLine("B. Steel");
													Console.WriteLine("C. Cobalt");
													Console.WriteLine("D. Shade Slicer");
													Console.WriteLine("E. Fire Scale");
													choice = Console.ReadLine();
													Console.Clear();
													if (choice == A || choice == "a")
													{
														if (buy == true)
														{
															buy4 = true;
														}
													}
													else if (choice == B || choice == "b")
													{
														if (buy == true)
														{
															buy4 = true;
														}
													}
													else if (choice == C || choice == "c")
													{
														if (buy == true)
														{
															buy2 = true;
														}
													}
													else if (choice == D || choice == "d")
													{
														if (buy == true)
														{
															buy2 = true;
														}
													}
													else if (choice == E || choice == "e")
													{
														if (buy == true)
														{
															buy2 = true;
														}
													}
												}
												#endregion
												#region mace
												else if (choice == D || choice == "d")
												{
													Console.WriteLine("To gain acess to more maces level up");
													Console.WriteLine("What type of mace do you want?");
													Console.WriteLine();
													Console.WriteLine("A. Iron");
													Console.WriteLine("B. Copper");
													Console.WriteLine("C. Glass");
													Console.WriteLine("D. Steel");
													Console.WriteLine("E. Drakestone");
													choice = Console.ReadLine();
													Console.Clear();
													if (choice == A || choice == "a")
													{
														if (buy == true)
														{
															buy3 = true;
														}
													}
													else if (choice == B || choice == "b")
													{
														if (buy == true)
														{
															buy3 = true;
														}
													}
													else if (choice == C || choice == "c")
													{
														if (buy == true)
														{
															buy3 = true;
														}
													}
													else if (choice == D || choice == "d")
													{
														if (buy == true)
														{
															buy3 = true;
														}
													}
													else if (choice == E || choice == "e")
													{
														if (buy == true)
														{
															buy3 = true;
														}
													}
												}
												#endregion
												else if (choice == E || choice == "e")
												{
													break;
												}
												else
												{
													Console.WriteLine("please enter a valid option");
												}
											}
										}
										#endregion
										#region Weapon Upgrade
										else if (choice == B || choice == "b")
										{
											Console.WriteLine("enter the number of the weapon you want improved");
											Console.WriteLine();
											int num = 0;
											int item_num = 1;
											while (num < Weapons.Count)
											{
												Console.WriteLine(item_num + ". " + Weapons[num]);
												item_num++;
												num++;
											}
										}
										#endregion
										#region Buying Armour
										else if (choice == C || choice == "c")
										{

										}
										#endregion
										#region Upgrade Armour
										else if (choice == D || choice == "d")
										{
											Console.WriteLine("what armour do you want to improve?");
										}
										#endregion
										#region Sell Items
										else if (choice == E && item == true || choice == "e" && item == true)
										{
											while (true)
											{

												Console.Clear();
												Console.WriteLine("What do  you want to sell?");
												int i = 0;
												int e = 1;
												while (i < Items.Count)
												{
													Console.WriteLine(e + ", " + Items[i]);
													i++;
													e++;
												}
												Console.WriteLine();
												Console.WriteLine("type the number of the item you want to sell");
												Console.WriteLine("to return to the shop type 'Back'");
												choice = Console.ReadLine();
												Console.Clear();
												if (choice == "Back" || choice == "back")
												{
													break;
												}
												else
												{
													i = Convert.ToInt32(choice) - 1;
													if (i < 0)
													{
														Console.WriteLine("please enter a valide number");
													}
													else if (Items[i] == "empty")
													{
														Console.WriteLine("there is no item in this slot please choose an item");
													}
													else
													{
														gold = gold + Items_Price[i];
														Console.WriteLine("+ " + Items_Price[i] + " Gold");
													}
												}
											}
										}
										#endregion
										#region Return To Main
										else if (choice == E && item == false || choice == "e" && item == false)
										{
											break;
										}
										else if (choice == F && item == true || choice == "f" && item == true)
										{
											break;
										}
										#endregion
									}
								}
								#endregion
								#region Alchemist
								else if (choice == B && full_game == true || choice == "b" && full_game == true)
								{
									while (true)
									{
										int PotionPrice;
										Console.WriteLine("welcome to Adria's Elixers");
										Console.WriteLine("Meeting all your potion needs since we opened");
										Console.WriteLine("Now, what do you need?");
										Console.WriteLine();
										Console.WriteLine("A. Potion of Health");
										Console.WriteLine("B. Potion of Magic");
										Console.WriteLine("C. Potion of Stamina");
										choice = Console.ReadLine();
										Console.Clear();
										if (choice == A || choice == "a")
										{
											PotionPrice = 30;
											if (gold >= PotionPrice)
											{
												gold = gold - PotionPrice;
												Items.Add("Potion of Health");
												Potions.Add("Potion of Health");
											}
											else if (gold < PotionPrice)
											{
												Console.WriteLine("you cannot afford this potion");
												break;
											}
										}
										else if (choice == B || choice == "b")
										{
											PotionPrice = 40;
											if (gold >= PotionPrice)
											{
												gold = gold - PotionPrice;
												Items.Add("Potion of Magic");
												Potions.Add("Potion of Magic");
											}
											else if (gold < PotionPrice)
											{
												Console.WriteLine("you cannot afford this potion");
												break;
											}
										}
										else if (choice == C || choice == "c")
										{
											PotionPrice = 45;
											if (gold >= PotionPrice)
											{
												gold = gold - PotionPrice;
												Items.Add("Potion of Stamina");
												Potions.Add("Potion of Stamina");
											}
											else if (gold < PotionPrice)
											{
												Console.WriteLine("you cannot afford this potion");
												break;
											}
										}
									}
								}
								#endregion
								#region Inn
								else if (choice == C || choice == "c")
								{
									while (true)
									{
										Console.WriteLine("Welcome to the Dunken Flame");
										Console.WriteLine("Here you can rest and get a drink");
										Console.WriteLine();
										Console.WriteLine("A. Rent a room (10 gold)");
										Console.WriteLine("B. Buy a drink");
										Console.WriteLine("C. Ask about jobs");
										Console.WriteLine("D. Back");
										choice = Console.ReadLine();
										Console.Clear();
										if (choice == A || choice == "a")
										{
											if (gold >= 10)
											{
												gold = gold - 10;
												Console.WriteLine("enjoy your stay");
												Thread.Sleep(2000);
												Console.Clear();
												if (zentos == 1)
												{
													Console.WriteLine("Resting");
													Thread.Sleep(1000);
													Console.Clear();
													Console.WriteLine("Resting.");
													Thread.Sleep(1000);
													Console.Clear();
													Console.WriteLine("Resting..");
													Thread.Sleep(1000);
													Console.Clear();
													Console.WriteLine("Resting...");
													Thread.Sleep(1000);
													Console.Clear();
													Console.WriteLine("LOL there is no actual loading by the way your now healed");
													Thread.Sleep(1000);
													zentos--;
												}
												Hp = maxHp;
												stamina = maxSt;
												magic_Energy = maxMg;
												break;
											}
											else if (gold < 10)
											{
												Console.WriteLine("Sorry but you dont have enough to rent the room");
											}
										}
										else if (choice == B || choice == "b")
										{
											while (true)
											{
												Console.WriteLine("We have three drinks for our costumers");
												Console.WriteLine();
												Console.WriteLine("A. Mages brew (20 gold)");
												Console.WriteLine("B. Melee potion (25 gold)");
												Console.WriteLine("C. Healing toper (30 gold)");
												Console.WriteLine("D. Back");
												choice = Console.ReadLine();
												Console.Clear();
												if (choice == A && gold >= 20 || choice == "a" && gold >= 20)
												{
													Potions.Add("Mages Brew");
												}
												else if (choice == B && gold >= 25 || choice == "b" && gold >= 25)
												{
													Potions.Add("Melee Potion");
												}
												else if (choice == C && gold >= 30 || choice == "c" && gold >= 30)
												{
													Potions.Add("Healing Toper");
												}
												else if (choice == D || choice == "d")
												{
													break;
												}
												else if (choice == A && gold < 20 || choice == "a" && gold < 20 || choice == B && gold < 25 || choice == "b" && gold < 25 || choice == C && gold < 30 || choice == "c" && gold < 30)
												{
													Console.WriteLine("Sorry but you cant afford that");
													Thread.Sleep(1000);
												}
												else
												{
													Console.WriteLine("please choose a valid option");
													Thread.Sleep(1000);
												}
											}
										}
										else if (choice == C || choice == "c")
										{
											Console.WriteLine("sorry no jobs are currently avalible");
											Thread.Sleep(1000);
										}
										else if (choice == D || choice == "d")
										{
											break;
										}
										else
										{
											Console.WriteLine("Please enter a valid option");
											Thread.Sleep(1000);
										}
									}
								}
								#endregion
								#region House Shop
								else if (choice == D && shop_option == "four" || choice == D && shop_option == "five" || choice == "d" && shop_option == "four" || choice == "d" && shop_option == "five")
								{
									while (true)
									{
										Console.WriteLine("Welcome to the housing market my dear customer");
										Console.WriteLine("what type of house are you in the market for?");
										Console.WriteLine();
										Console.WriteLine("A. Small House (5000)");
										Console.WriteLine("B. Back");
										choice = Console.ReadLine();
										Console.Clear();
										if (choice == A && gold >= 5000 || choice == "a" && gold >= 5000)
										{
											Console.WriteLine("Enjoy your new house");
											Home = true;
											Thread.Sleep(1000);
										}
										else if (choice == A && gold < 5000 || choice == "a" && gold < 5000)
										{
											Console.WriteLine("sorry you  dont have enough gold");
											Thread.Sleep(1000);
										}
										else if (choice == B || choice == "b")
										{
											break;
										}
										else
										{
											Console.WriteLine("please enter valid option");
										}
									}
								}
								#endregion
								#region Enchanter
								else if (choice == E && shop_option == "five" || choice == "e" && shop_option == "five")
								{

								}
								#endregion
								#region Return to main
								else if (choice == B && full_game == false || choice == "b" && full_game == false || choice == D && shop_option != "four" || choice == "d" && shop_option != "four" || choice == E && shop_option != "five" && shop_option == "four" || choice == "e" && shop_option != "five" && shop_option == "four" || choice == F && shop_option == "five" || choice == "f" && shop_option == "five")
								{
									break;
								}
								#endregion
							}
						}
						#endregion
						#region stats
						else if (choice == D || choice == "d")
						{
							Console.WriteLine("Class: " + Class_Name);
							Console.WriteLine("Level: " + level);
							Console.WriteLine("Health: " + Hp);
							Console.WriteLine("stamina: " + stamina);
							Console.WriteLine("magicka: " + magic_Energy);
							Console.WriteLine("Exp: " + exp);
							Console.WriteLine("To next level: " + expToNxt);
							Console.WriteLine("Gold: " + gold);
							Console.WriteLine("Difficulty: " + dif);
							if (type == 1.1 || type == 1.2 || type == 1.3 || type == 1.4 || type == 1.5 || type == 1.6 || type == 3 || type == 9 || buy1 == true)
							{
								Console.WriteLine("Staff strength: " + staff[t]);
							}
							else if (type == 2 || type == 6 || type == 9 || buy2 == true)
							{
								Console.WriteLine("Sword strenth: " + sword[t]);
							}
							else if (type == 3 || type == 4 || buy3 == true)
							{
								Console.WriteLine("Mace strength: " + mace[t]);
							}
							else if (type == 5 || type == 7 || buy4 == true)
							{
								Console.WriteLine("Dagger strength: " + dagger[t]);
							}
							else
							{
								Console.WriteLine("you have no personal weapon");
							}
							if (levelPerks >= 1)
							{
								Console.WriteLine("A. access level up menu");
								Console.WriteLine();
							}
							Console.WriteLine("To upgrade weapons or buy new ones visit the shop");
							choice = Console.ReadLine();
							#region Level Up
							if (choice == "A" && levelPerks >= 1 || choice == "a" && levelPerks >= 1)
							{
								Console.Clear();
								Console.WriteLine("level perks: " + levelPerks);
								Console.WriteLine();
								Console.WriteLine();
								Console.WriteLine("A. Armour");
								Console.WriteLine("B. Swordsmanship");
								Console.WriteLine("C. Magic");
								Console.WriteLine("D. Smithing");
								Console.WriteLine("E. Shadow Stalk");
								choice = Console.ReadLine();
							}
							#endregion
						}
						#endregion
						#region Home
						else if (choice == E && Home == true || choice == "e" && Home == true)
						{
							Console.WriteLine();
						}
						#endregion
						#region Game Info
						else if (choice == E && Home == false || choice == "e" && Home == false || choice == F && Home == true || choice == "f" && Home == true)
						{
							while (true)
							{
								Console.Clear();
								Console.WriteLine("What would you like info on?");
								Console.WriteLine();
								Console.WriteLine("A. The Creature Fields");
								Console.WriteLine("B. The Dark Dungeons");
								Console.WriteLine("C. The Leveling system");
								Console.WriteLine("D. Weapon machanics");
								Console.WriteLine("E. Change Game Difficulty");
								Console.WriteLine("F. Back");
								Console.WriteLine("For access to the WIP areas and classes restart game on main menu with 'restart' then type 'unlock' when selecting class");
								choice = Console.ReadLine();
								Console.Clear();
								#region Creature Feilds
								if (choice == A || choice == "a")
								{
									while (true)
									{
										Console.Clear();
										Console.WriteLine("The Creature Fields are where most low level adventures go to start their training");
										Console.WriteLine("it is also where most low level creatures live");
										Console.WriteLine("However there have been rumors that some powerful boss creatures have been sighted their");
										Console.WriteLine();
										Console.WriteLine("Would you like info on some of the different areas of the creature feilds?");
										Console.WriteLine();
										Console.WriteLine("A. Burning Plains");
										Console.WriteLine("B. Drake Mine");
										Console.WriteLine("C. Broken Sky Peak");
										Console.WriteLine("D. Withering Swamps");
										Console.WriteLine("E. Shattered Wasteland");
										Console.WriteLine("F. Back");
										choice = Console.ReadLine();
										Console.Clear();
										if (choice == A || choice == "a")
										{
											Console.WriteLine("The Burning Plains is a deslote land full of fire and ash");
											Console.WriteLine("full of fire imps, ash wolves, and some many other creatures it is near impossible for humans to survive in the area for very long");
											Console.WriteLine("this is due to the eruption of Mt. Pergatory");
											Console.WriteLine("turning what use to be a peaceful plain of flowers into the deslate land it is now");
											Console.WriteLine("but there is more to this story than meets the eye");
											Console.WriteLine("with time who knows what could be uncovered");
										}
										else if (choice == B || choice == "b")
										{
											Console.WriteLine("The Drake Mine");
										}
										else if (choice == C || choice == "c")
										{
											Console.WriteLine("Broken Sky Peak");
										}
										else if (choice == D || choice == "d")
										{
											Console.WriteLine("The Withering Swamps");
										}
										else if (choice == E || choice == "e")
										{
											Console.WriteLine("The Shattered Wastelands are a broken land full of chaos and destruction");
											Console.WriteLine("It has been like that for what seems like forever");
											Console.WriteLine("No body knows what it use to look like or what caused it become the way it is");
											Console.WriteLine("the only thing that is know is that the creatures that dwell there are as deadly as dungeon creatures");
											Console.WriteLine("there has also been rumors of something with a terrifying dark power lurking deep within the wasteland");
										}
										else if (choice == F || choice == "f")
										{
											break;
										}
										else
										{
											Console.Clear();
											Console.WriteLine("Please enter Valid option");
											Console.ReadLine();
											Console.Clear();
										}
									}
								}
								#endregion
								#region Dungeon Info
								else if (choice == B || choice == "b")
								{
									Console.WriteLine("The Dark Dungeons are not actually in this dimension only the door to it is");
									Console.WriteLine("the dungeons are all in seperates dimension that have different teriffying enemies");
									Console.WriteLine("once you enter a dungeon you cannot leave until you have cleared it");
									Console.WriteLine("thought if you clear the dungeon then you get a spectial item that has a special power");
									Console.WriteLine("what will you find?");
									Console.ReadLine();
								}
								#endregion
								#region Level Increase
								else if (choice == C || choice == "c")
								{
									Console.WriteLine("to put it most simply with each enemy killed and dungeon cleared you get experience");
									Console.WriteLine("once you get enough experience you level up");
									Console.WriteLine("the level up will allow you to use a point to increase your stamina, or magic");
									Console.WriteLine("you can also increase one of your statis catigories to strengthen your fighting styles");
									Console.WriteLine();
									Console.WriteLine("To access the level menu just look at you character stats menu");
									Console.ReadLine();
								}
								#endregion
								#region Weapon Info
								else if (choice == D || choice == "d")
								{
									while (true)
									{
										Console.WriteLine("select what you would like info on");
										Console.WriteLine();
										Console.WriteLine("A. weapons in general");
										Console.WriteLine("B. staff");
										Console.WriteLine("C. dagger");
										Console.WriteLine("D. sword");
										Console.WriteLine("E. mace");
										Console.WriteLine("F. back");
										choice = Console.ReadLine();
										Console.Clear();
										if (choice == A || choice == "a")
										{
											Console.WriteLine("all weapons have simple base stats that doesnt do alot of damage");
											Console.WriteLine("also for some classes you start off without a weapon");
											Console.WriteLine("dont worry though you can buy and upgrade your weapons and amrour at the store");
											Console.ReadLine();
										}
										else if (choice == B || choice == "b")
										{
											Console.WriteLine("Staffs are made to do damage that effects the eenmies mind and body however it is weak to those with high magic defence and cannot do much physical damage");
											Console.WriteLine("also if you run out of magicka then the staff cannot be used for spells");
											Console.WriteLine("as a fight progresses however your magicka will slowly regenerate");
											Console.WriteLine("to increase damage and magicka efficency upgrade it in the shop");
											Console.ReadLine();
										}
										else if (choice == C || choice == "c")
										{
											Console.WriteLine("daggers are the most efficient weapons when it comes to stamina usage");
											Console.WriteLine("the trade off for this however is that daggers deal the least amount of damage");
											Console.WriteLine("You can upgrade your dagger in the shop");
											Console.ReadLine();
										}
										else if (choice == D || choice == "d")
										{
											Console.WriteLine("swords come in two forms, greatswords and broadswords.");
											Console.WriteLine("greatswords consume more stamina in usage than the broadsword");
											Console.WriteLine("in exchange it deals more damage");
											Console.WriteLine("Broadswords are more persice and can have a chance at peircing any armour that an enemy is wearing");
											Console.ReadLine();
										}
										else if (choice == E || choice == "e")
										{
											Console.WriteLine("the mace takes the most stamina to use and deals only moderate damage to enemies");
											Console.WriteLine("it like all other weapons can be upgraded in the shop to deal more damage");
											Console.ReadLine();
										}
										else if (choice == F || choice == "f")
										{
											break;
										}
									}
								}
								#endregion
								#region difficulty change
								else if (choice == D || choice == "d")
								{
									Console.WriteLine("please enter the difficulty level you would like to set the game to (1 easiest - 10 hardest)");
									choice = Console.ReadLine();
									Console.Clear();
									if (choice != "1" && choice != "2" && choice != "3" && choice != "4" && choice != "5" && choice != "6" && choice != "7" && choice != "8" && choice != "9" && choice != "10")
									{
										Console.WriteLine("In order to change difficulty please enter valid choice between 1 and 10");
										Thread.Sleep(3000);
										Console.Clear();
									}
									else
									{
										dif = Convert.ToInt32(choice);
										Console.WriteLine("Difficulty has been changed to Level: " + dif);
										Thread.Sleep(1000);
										Console.Clear();
									}
								}
								#endregion
								else if (choice == F || choice == "f")
								{
									break;
								}
								else
								{
									Console.WriteLine("please enter a valid letter");
									Console.ReadLine();
								}
							}
						}
						#endregion
						#region Inventory
						else if (choice == F && Home == false || choice == "f" && Home == false || choice == G && Home == true || choice == "g" && Home == true)
						{
							while (true)
							{
								Console.Clear();
								int inventoryNum = 0;
								int itemNum = 1;
								Console.WriteLine("A. Weapons");
								Console.WriteLine("B. Armour");
								Console.WriteLine("C. Potions");
								Console.WriteLine("D. Misc Items");
								Console.WriteLine("E. Back");
								choice = Console.ReadLine();
								Console.Clear();
								#region Weapons
								if (choice == A || choice == "a")
								{
									Console.WriteLine("To change equiped weapon type 'equip'");
									Console.WriteLine("To go back just hit enter");
									Console.WriteLine();
									Console.WriteLine("Weapon Name			Damage			Weapon Type		Enchantment");
									while (inventoryNum < Weapons.Count)
									{
										if (WeaponType[inventoryNum] == "Sword")
										{
											Console.WriteLine(itemNum + ". " + Weapons[inventoryNum] + "			" + WeaponDamage[inventoryNum] + "			" + WeaponType[inventoryNum] + "			" + WeaponEnchantment[inventoryNum]);
											itemNum++;
											inventoryNum++;
										}
										else if (WeaponType[inventoryNum] == "Mace")
										{
											Console.WriteLine(itemNum + ". " + Weapons[inventoryNum] + "			" + WeaponDamage[inventoryNum] + "			" + WeaponType[inventoryNum] + "			" + WeaponEnchantment[inventoryNum]);
											itemNum++;
											inventoryNum++;
										}
										else if (WeaponType[inventoryNum] == "Bow")
										{
											Console.WriteLine(itemNum + ". " + Weapons[inventoryNum] + "			" + WeaponDamage[inventoryNum] + "			" + WeaponType[inventoryNum] + "			" + WeaponEnchantment[inventoryNum]);
											itemNum++;
											inventoryNum++;
										}
									}
									choice = Console.ReadLine();
									if (choice == "Equip" || choice == "equip")
									{
										Console.WriteLine("Enter the number of the weapon you want to equip");
										int weaponNum = Convert.ToInt32(Console.ReadLine());
										rightHandWeaponEquiped = Weapons[weaponNum];
										Console.WriteLine("You equiped " + Weapons[weaponNum]);
										Thread.Sleep(2000);
									}
								}
								#endregion
								#region Armour
								else if (choice == B || choice == "b")
								{
									while (inventoryNum < Armour.Count)
									{
										if (ArmourType[inventoryNum] == "Armour")
										{
											Console.WriteLine(itemNum + ". " + Armour[inventoryNum]);
											itemNum++;
											inventoryNum++;
										}
										else if (ArmourType[inventoryNum] == "Shield")
										{
											Console.WriteLine(itemNum + ". " + Armour[inventoryNum]);
											itemNum++;
											inventoryNum++;
										}
									}
									Console.ReadLine();
								}
								#endregion
								#region Potions
								else if (choice == C || choice == "c")
								{
									while (inventoryNum < Potions.Count)
									{
										Console.WriteLine(itemNum + ". " + Potions[inventoryNum]);
										itemNum++;
										inventoryNum++;
									}
									Console.ReadLine();
								}
								#endregion
								#region Misc
								else if (choice == D || choice == "d")
								{
									while (inventoryNum < Items.Count)
									{
										Console.WriteLine(itemNum + ". " + Items[inventoryNum]);
										itemNum++;
										inventoryNum++;
									}
									Console.ReadLine();
								}
								#endregion
								else if (choice == E || choice == "e")
								{
									break;
								}
							}
						}
						#endregion
						#region Magic
						else if (choice == G && Home == false || choice == "g" && Home == false || choice == H && Home == true || choice == "h" && Home == true)
						{
							while (true)
							{
								int nte = 0;
								string magicType;
								Console.WriteLine("Magic types");
								Console.WriteLine();
								Console.WriteLine("A. Chaos");
								Console.WriteLine("B. Order");
								Console.WriteLine("C. Pyromancy");
								Console.WriteLine("D. Necromancy");
								Console.WriteLine("E. Cryomancy");
								Console.WriteLine("F. Void");
								Console.WriteLine("G. Back");
								choice = Console.ReadLine();
								Console.Clear();
								int ntes = 0;
								if (choice == A || choice == "a")
								{
									magicType = "Chaos";
									while (nte < MagicType.Count)
									{

										if (magicType == MagicType[nte])
										{
											ntes++;
											Console.WriteLine(ntes + ". " + Magic[nte]);
											Console.WriteLine("		" + MagicDamage[nte] + " Damage");
											Console.WriteLine("		" + MagicCost[nte] + " magic cost");
											Console.WriteLine("		" + remnantMagic[nte] + " other damage");
										}
										nte++;
									}
								}
								else if (choice == B || choice == "b")
								{
									magicType = "Order";
									while (nte < MagicType.Count)
									{
										if (magicType == MagicType[nte])
										{
											ntes++;
											Console.WriteLine(ntes + ". " + Magic[nte]);
											Console.WriteLine("		" + MagicDamage[nte] + " Damage");
											Console.WriteLine("		" + MagicCost[nte] + " magic cost");
											Console.WriteLine("		" + remnantMagic[nte] + " other damage");
										}
										nte++;

									}
								}
								else if (choice == C || choice == "c")
								{
									magicType = "Pyromancy";
									while (nte < MagicType.Count)
									{
										if (magicType == MagicType[nte])
										{
											ntes = ntes + 1;
											Console.WriteLine(ntes + ". " + Magic[nte]);
											Console.WriteLine("		" + MagicDamage[nte] + " Damage");
											Console.WriteLine("		" + MagicCost[nte] + " magic cost");
											Console.WriteLine("		" + remnantMagic[nte] + " other damage");
										}
										nte++;
									}
								}
								else if (choice == D || choice == "d")
								{
									magicType = "Necromancy";
									while (nte < MagicType.Count)
									{
										if (magicType == MagicType[nte])
										{
											ntes++;
											Console.WriteLine(ntes + ". " + Magic[nte]);
											Console.WriteLine("		" + MagicDamage[nte] + " Damage");
											Console.WriteLine("		" + MagicCost[nte] + " magic cost");
											Console.WriteLine("		" + remnantMagic[nte] + " other damage");
										}
										nte++;
									}
								}
								else if (choice == E || choice == "e")
								{
									magicType = "Cryomancy";
									while (nte < MagicType.Count)
									{
										if (magicType == MagicType[nte])
										{
											ntes++;
											Console.WriteLine(ntes + ". " + Magic[nte]);
											Console.WriteLine("		" + MagicDamage[nte] + " Damage");
											Console.WriteLine("		" + MagicCost[nte] + " magic cost");
											Console.WriteLine("		" + remnantMagic[nte] + " other damage");
										}
										nte++;
									}
								}
								else if (choice == F || choice == "f")
								{
									magicType = "Void";
									while (nte < MagicType.Count)
									{
										if (magicType == MagicType[nte])
										{
											ntes++;
											Console.WriteLine(ntes + ". " + Magic[nte]);
											Console.WriteLine("		" + MagicDamage[nte] + " Damage");
											Console.WriteLine("		" + MagicCost[nte] + " magic cost");
											Console.WriteLine("		" + remnantMagic[nte] + " other damage");
										}
										nte++;
									}
								}
								else if (choice == G || choice == "g")
								{
									break;
								}
								Thread.Sleep(2350);
								Console.Clear();
							}
						}
						#endregion
						#region cheats
						#region restart
						else if (choice == "restart")
						{
							Console.WriteLine("Restarting Game");
							Thread.Sleep(5000);
							Console.Clear();
							break;
						}
						#endregion
						#region Random Boss
						else if (choice == "Console.BossR")
						{

						}
						#endregion
						#region gold_cheat
						else if (choice == "Shade Kingdom" && cheats_used < 6 || choice == "shade kingdom" && cheats_used < 6)
						{
							Console.WriteLine("20000 gold added");
							gold = gold + 20000;
							Thread.Sleep(1000);
							if (adminAccess == false)
							{
								cheats_used++;
							}
						}
						#endregion
						#region High Health
						else if (choice == "console: infinite" && cheats_used < 6)
						{
							Console.WriteLine("Max Health set to 5000");
							maxHealth = 5000;
							if (adminAccess == false)
							{
								cheats_used++;
							}
						}
						#endregion
						#region Ultimate Armour
						else if (choice == "system: time split" && cheats_used < 6)
						{
							EquipedArmour = "Dragon Shade Armour";
							EquipedArmourStats = 50000;
							if (adminAccess == false)
							{
								cheats_used++;
							}
						}
						#endregion
						#region Ultimate Weapon
						else if (choice == "system: shade gate" && cheats_used < 6)
						{
							rightHandWeaponEquiped = "Final Kingdom";
							rightHandWeaponStats = 10000;
							leftHandWeaponEquiped = "Shadow Of Death";
							leftHandWeaponStats = 10000;
							if (adminAccess == false)
							{
								cheats_used++;
								cheats_used++;
								cheats_used++;
							}
						}
						#endregion
						#region Cheat Test
						else if (choice == "set 6")
						{
							Console.WriteLine("cheat test activated");
							Thread.Sleep(600);
							cheats_used = 6;
							finalWarning = 1;
						}
						#endregion
						#region Cheat Halt
						else if (choice == "system: shade gate" && cheats_used >= 6 && finalWarning == 0 || choice == "system: time spliter" && cheats_used >= 6 && finalWarning == 0 || choice == "console: infinite" && cheats_used >= 6 && finalWarning == 0 || choice == "system: shade kingdom" && cheats_used >= 6 && finalWarning == 0 || choice == "system: Shade Kingdom" && cheats_used >= 6 && finalWarning == 0)
						{
							Console.WriteLine("You have hit the limit on your cheating for that if you attempt to cheat again you will be reset to level 1 and will have all your items, other than your class starting items, confiscated.");
							Console.WriteLine("if you  attempt to cheat after that you will be kicked from the game and all save data deleted");
							Thread.Sleep(3000);
							finalWarning = 1;
						}
						else if (choice == "system: shade gate" && finalWarning == 1 || choice == "system: time spliter" && finalWarning == 1 || choice == "console: infinite" && finalWarning == 1 || choice == "system: shade kingdom" && finalWarning == 1 || choice == "system: Shade Kingdom" && finalWarning == 1)
						{
							Console.WriteLine("You have been warned and for attempting to cheat again your level has been reset and all your items have been confiscated");
							Console.WriteLine("This is your FINAL WARNING if you attempt to cheat again you will be banned from the game PERMINATLY!!!");
							Thread.Sleep(5000);
							Console.Clear();
							Console.WriteLine("YOU");
							Thread.Sleep(1000);
							Console.Clear();
							Console.WriteLine("HAVE");
							Thread.Sleep(1000);
							Console.Clear();
							Console.WriteLine("BEEN");
							Thread.Sleep(1000);
							Console.Clear();
							Console.WriteLine("WARNED");
							Thread.Sleep(5000);
							Console.Clear();
							finalWarning = 2;
						}
						else if (choice == "system: shade gate" && finalWarning == 2 || choice == "system: time spliter" && finalWarning == 2 || choice == "console: infinite" && finalWarning == 2 || choice == "system: shade kingdom" && finalWarning == 2 || choice == "system: Shade Kingdom" && finalWarning == 2)
						{
							Console.WriteLine("YOU HAVE BROKEN THE LAWS OF THE GAME AND FOR THAT YOU WILL BE BANNED FORM THIS GAME FOREVER");
							Thread.Sleep(2000);
							Console.Clear();
							break;
						}
						#endregion
						else
						{
							Console.WriteLine("Please enter a valid option");
							Thread.Sleep(1000);
						}
						#endregion
						#region Extra Code
						//01100011 00110010 00110001 01101100 01011010 01011000 01001110 00110000 01100001 01010111 00110101 01101000 01100001 01001000 01010010 01101100 01100011 01101101 00111001 01110100 01100011 00110010 01101100 01110101 01100001 01010111 01110100 01110011 01011001 01011000 01100100 01101100 01100100 00110010 01010010 01110011 01100011 01101101 00111001 00110011 01011010 01010111 01101000 00110000 01000100 01010001 01101111
						//01100100 01001000 01010110 01110110 01100001 01000111 01100100 00110001 01100010 00110011 01001010 01101111 01100100 01000111 01010010 01101100 01100100 01101101 01000110 01101100 01100100 00110011 01001110 00110011 01100010 00110010 01010010 01101000 01100001 01001000 01001110 01101011 01100010 01101101 01000110 01111001 01011010 01010111 00110101 01111001 01100010 00110010 01001110 00110101 01100011 01101101 01010110 00110010 01011010 01010111 00110101 01110000 01100011 00110011 01010010 01111010 01100001 01011000 01101000 01101100 01011001 00110010 01101100 01101110 01011001 01010111 00110000
						//01100011 00110010 00110001 01101100 01011010 01011000 01001110 00110000 01100001 01010111 01111000 01110011 01011001 01011000 01010010 01110110 01100010 01101110 01001110 01110000 01100101 01011000 01010010 01110000 01100010 01000111 01000110 01101100 01100011 01101110 01001010 01110110 01011010 01101110 01101100 00110000 01100001 01010111 01111000 01101000 01011010 01011000 01001010 01110101 01100001 01010111 01011010 01110011 01011010 01011000 01001110 01111001 01100100 01010111 00111001 00110101 01100100 01000111 00110101 01101000 01100010 01001000 01000010 01110110 01100100 01000111 01010010 01110101 01011001 01011000 01001110 01110100 01011001 01010111 01010110 01111001 01011010 01000111 01100100 01110101 01100001 01010111 01010110 01101100 01100011 00110011 01000010 01110110 01100100 01001000 01001110 01110110 01100100 01001000 01010110 01110110 01100101 01010111 01111000 01110011 01011010 01011000 01010010 01110110 01100001 01001000 01100100 01101100 01100011 00110010 00111001 01101111 01100100 01000111 01010110 01111001 01011001 01011000 01100100 01101100 01011001 01100111
						//01011010 01011000 01001010 01101100 01100001 01001000 01010010 00110000 01100010 00110010 00110101 01111010 01100001 01010111 01101000 01101010 01100001 01010111 01101000 00110011 01100100 01000111 01000110 01101111 01100100 01001000 01001010 01110110 01011010 01101101 01110100 01110110 01100010 00110010 01111000 00110000 01100010 00110010 00110101 01110110 01011010 01001000 01010010 00110001 01011001 01101101 01010010 01110011 01100010 00110011 01010010 01111001 01100100 01010111 00111001 00110101 01100100 01000111 01000110 01101111 01100100 00110010 00111001 00110000 01100010 01101101 01101100 01110111 01011010 01010111 01010110 01101011 01100011 00110010 01000110 01110010 01100010 00110010 00111001 01110011 01011010 01011000 01010110 01110011 01011001 01011000 01011010 01101100 01011001 00110010 01000110 01101101 01100100 01000111 01000110 01111010 01011010 00110010 00110101 01110000 01100001 01001000 01010010 00110000 01100011 00110011 01010110 01111001 01100100 01001000 01001010 01101100 01100100 01101101 01010110 01110101 01011010 01011000 01001010 01110000 01011010 01101101 01011010 01110110 01100010 01000111 00111001 01111001 01100100 01000111 00110101 01110110 01011001 00110010 01010110 01110010 01011001 01011000 01010010 01101011 01100010 01101101 01000110 01111010 01100100 00110010 00111001 01101011 01011001 01010111 01101000 01111010 01011010 01010111 01101000 00110000 01100001 01001000 01010010 01110000 01100100 00110010 01010110 01101010 01100010 01101101 01000110 01101011 01011001 00110010 01101100 01101110 01011001 01010111 00110001 01101011 01100010 01101101 01000110 01101111 01100100 01001000 01010110 01111001 01100100 01000111 01011010 01110110 01100100 01001000 01001010 01101000 01011010 01010111 01101000 01101100 01100001 01001000 01010010 01110110 01100100 01000111 00110101 01110000 01100011 01000111 01010110 01101100 01011010 01001000 01001010 01101100 01011010 01011000 01000010 01101011 01100010 01101101 01000110 01111010 01011010 01011000 01101100 01101100 01100011 01101110 01010110 01110110 01100101 01010111 00110101 01101100 01100011 01000111 00111001 01101100 01100011 01101101 01010110 01101111 01100100 01001000 01101100 01110011 01100100 01011000 01001010 00110000 01100011 00110010 01101100 00110000 01011001 01010111 01101000 00110011 01011010 01010111 01010110 01111010 01000100 01010001 01101111 00111101
						#endregion
					}
					if (finalWarning == 2)
					{
						Console.WriteLine("Goodbye");
						Thread.Sleep(500);
						break;
					}

				}
				#endregion
			}
			#endregion
		}
		static string Resistence(string creatureType, string creatureName, string region)
		{
			string resistance = "";
			if (creatureType == "Beast")
			{
				resistance = "";
			}
			else if (creatureType == "God")
			{
			}
			return resistance;
		}
		static string Weakness(string creatureType, string creatureName, string region)
		{
			string weakness = "";
			if (region == "Air")
			{
				if (creatureType == "Beast")
				{
				}
				else if (creatureType == "Demon")
				{
				}
				else if (creatureType == "Shade")
				{
				}
				else if (creatureType == "Construct")
				{
				}
				else if (creatureType == "Serpent")
				{
				}
				else if (creatureType == "Human")
				{
				}
				else if (creatureType == "Spirit")
				{
				}
				else if (creatureType == "Dragon")
				{
				}
				else if (creatureType == "Demon-Beast")
				{
				}
				else if (creatureType == "God")
				{
					if (creatureName == "Neratie, Godess of Wind")
					{
						weakness = "Corruption";
					}
				}
				else if (creatureType == "Unknown")
				{
				}
				else if (creatureType == "Abomination")
				{
				}
				else if (creatureType == "Shadow")
				{
				}
				else if (creatureType == "Undead")
				{
				}
			}
			else if (region == "Fire")
			{
				if (creatureType == "Beast")
				{
				}
				else if (creatureType == "Demon")
				{
				}
				else if (creatureType == "Shade")
				{
				}
				else if (creatureType == "Construct")
				{
				}
				else if (creatureType == "Serpent")
				{
				}
				else if (creatureType == "Human")
				{
				}
				else if (creatureType == "Spirit")
				{
				}
				else if (creatureType == "Dragon")
				{
				}
				else if (creatureType == "Demon-Beast")
				{
				}
				else if (creatureType == "God")
				{
					if (creatureName == "Fire God Enracu")
					{
						weakness = "Water";
					}
				}
				else if (creatureType == "Unknown")
				{
				}
				else if (creatureType == "Abomination")
				{
				}
				else if (creatureType == "Shadow")
				{
				}
				else if (creatureType == "Undead")
				{
				}
			}
			else if (region == "Water")
			{
				if (creatureType == "Beast")
				{
				}
				else if (creatureType == "Demon")
				{
				}
				else if (creatureType == "Shade")
				{
				}
				else if (creatureType == "Construct")
				{
				}
				else if (creatureType == "Serpent")
				{
				}
				else if (creatureType == "Human")
				{
				}
				else if (creatureType == "Spirit")
				{
				}
				else if (creatureType == "Dragon")
				{
				}
				else if (creatureType == "Demon-Beast")
				{
				}
				else if (creatureType == "God")
				{
					if (creatureName == "Sea God Friga")
					{
						weakness = "Lightning";
					}
				}
				else if (creatureType == "Unknown")
				{
				}
				else if (creatureType == "Abomination")
				{
				}
				else if (creatureType == "Shadow")
				{
				}
				else if (creatureType == "Undead")
				{
				}
			}
			else if (region == "Earth")
			{
				if (creatureType == "Beast")
				{
				}
				else if (creatureType == "Demon")
				{
				}
				else if (creatureType == "Shade")
				{
				}
				else if (creatureType == "Construct")
				{
				}
				else if (creatureType == "Serpent")
				{
				}
				else if (creatureType == "Human")
				{
				}
				else if (creatureType == "Spirit")
				{
				}
				else if (creatureType == "Dragon")
				{
				}
				else if (creatureType == "Demon-Beast")
				{
				}
				else if (creatureType == "God")
				{
					if (creatureName == "Mountain God")
					{
						weakness = "Fire";
					}
				}
				else if (creatureType == "Unknown")
				{
				}
				else if (creatureType == "Abomination")
				{
				}
				else if (creatureType == "Shadow")
				{
				}
				else if (creatureType == "Undead")
				{
				}
			}
			else if (region == "Waste")
			{
				if (creatureType == "Beast")
				{
				}
				else if (creatureType == "Demon")
				{
				}
				else if (creatureType == "Shade")
				{
				}
				else if (creatureType == "Construct")
				{
				}
				else if (creatureType == "Serpent")
				{
				}
				else if (creatureType == "Human")
				{
				}
				else if (creatureType == "Spirit")
				{
				}
				else if (creatureType == "Dragon")
				{
				}
				else if (creatureType == "Demon-Beast")
				{
				}
				else if (creatureType == "God")
				{
					if (creatureName == "")
					{
						weakness = "Pure";
					}
				}
				else if (creatureType == "Unknown")
				{
				}
				else if (creatureType == "Abomination")
				{
				}
				else if (creatureType == "Shadow")
				{
				}
				else if (creatureType == "Undead")
				{
				}
			}
			else if (region == "Shadow")
			{
				if (creatureType == "Beast")
				{
				}
				else if (creatureType == "Demon")
				{
				}
				else if (creatureType == "Shade")
				{
				}
				else if (creatureType == "Construct")
				{
				}
				else if (creatureType == "Serpent")
				{
				}
				else if (creatureType == "Human")
				{
				}
				else if (creatureType == "Spirit")
				{
				}
				else if (creatureType == "Dragon")
				{
				}
				else if (creatureType == "Demon-Beast")
				{
				}
				else if (creatureType == "God")
				{
					if (creatureName == "")
					{
						weakness = "";
					}
				}
				else if (creatureType == "Unknown")
				{
				}
				else if (creatureType == "Abomination")
				{
				}
				else if (creatureType == "Shadow")
				{
				}
				else if (creatureType == "Undead")
				{
				}
			}
			else if (region == "Darkness")
			{
				if (creatureType == "Beast")
				{
				}
				else if (creatureType == "Demon")
				{
				}
				else if (creatureType == "Shade")
				{
				}
				else if (creatureType == "Construct")
				{
				}
				else if (creatureType == "Serpent")
				{
				}
				else if (creatureType == "Human")
				{
				}
				else if (creatureType == "Spirit")
				{
				}
				else if (creatureType == "Dragon")
				{
				}
				else if (creatureType == "Demon-Beast")
				{
				}
				else if (creatureType == "God")
				{
					if (creatureName == "")
					{
						weakness = "";
					}
				}
				else if (creatureType == "Unknown")
				{
				}
				else if (creatureType == "Abomination")
				{
				}
				else if (creatureType == "Shadow")
				{
				}
				else if (creatureType == "Undead")
				{
				}
			}
			else if (region == "Shadow-Darkness")
			{
				if (creatureType == "Beast")
				{
				}
				else if (creatureType == "Demon")
				{
				}
				else if (creatureType == "Shade")
				{
				}
				else if (creatureType == "Construct")
				{
				}
				else if (creatureType == "Serpent")
				{
				}
				else if (creatureType == "Human")
				{
				}
				else if (creatureType == "Spirit")
				{
				}
				else if (creatureType == "Dragon")
				{
				}
				else if (creatureType == "Demon-Beast")
				{
				}
				else if (creatureType == "God")
				{
					if (creatureName == "Haster, the Exiled God")
					{
						weakness = "None";
					}
				}
				else if (creatureType == "Unknown")
				{
				}
				else if (creatureType == "Abomination")
				{
				}
				else if (creatureType == "Shadow")
				{
				}
				else if (creatureType == "Undead")
				{
				}
			}
			return weakness;
		}
	}
}