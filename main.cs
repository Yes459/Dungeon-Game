using System;

public class DungeonGame {
	
	public static void Main () {
		
		Stats PlayerStats;
		
		PlayerStats.Guilders = 0;
		PlayerStats.Level = 1;
		PlayerStats.XP = 0;
		
		PlayerStats.PhysicalDefense = 1;
		PlayerStats.PhysicalDamage = 5;
		
		PlayerStats.MagicDefense = 1;
		PlayerStats.MagicDamage = 5;
		
		PlayerStats.MaxHealth = 100;
		PlayerStats.Health = PlayerStats.MaxHealth;
		
		PlayerStats.MaxMagic = 100;
		PlayerStats.Magic = PlayerStats.MaxMagic;
		
		PlayerStats.MaxStamina = 100;
		PlayerStats.Stamina = PlayerStats.MaxStamina;
		
		bool[] Secrets = new bool[5];
		
		Secrets[0] = false; //Egg secret
		Secrets[1] = false; //Clay secret
		Secrets[2] = false; //Math secret
		Secrets[3] = false; //Dragon secret
		Secrets[4] = false; //Hangman secret
		
		string BlackMarket = "";
		bool BlackMarketFound = false;
		
		for (int i = 0; i == 0; i += 0) {
			
			if (PlayerStats.Health <= 0) {
			
				Console.WriteLine("You Died");
				i++;
				break;
			
			}
			
			Console.WriteLine("What would you like to do?");		
			Console.WriteLine("1. Check stats");		
			Console.WriteLine("2. Shop");		
			Console.WriteLine("3. Find a Dungeon");
			Console.WriteLine("4. Sell your soul" + BlackMarket);
			
			string Answer = Console.ReadLine();
			
			Console.WriteLine("");
			
			if (Answer == "1") {
				
				DungeonGame.CheckStats(PlayerStats, "Your Stats");
				
			} else if (Answer == "2") {
				
				PlayerStats = Shop(PlayerStats);
				
			} else if (Answer == "3") {
				
				PlayerStats = DungeonSearch(PlayerStats);
				
			} else if (Answer == "4") {
				
				PlayerStats.Guilders += 619747382;
				PlayerStats.Health = 0;
				Console.WriteLine("You now have " + PlayerStats.Guilders + " guilders, but you are now dead, and the son that you hate inherited all of the money.");
				break;
				
			} else if (Answer == "5") {
				
				if (!BlackMarketFound) {
					
					BlackMarket = "\n5. Black market";
					BlackMarketFound = true;
					
				}
				
				PlayerStats = DungeonGame.BlackMarket(PlayerStats, Secrets);
				
			} else if (Answer == "6" && BlackMarketFound) {
				
				Console.WriteLine("Nice try.");
				Console.ReadLine();
				
			} else if (Answer == "Egg" && !Secrets[0]) {
				
				Console.WriteLine("Congratulations, you found a secret and got 2,500 guilders");
				PlayerStats.Guilders += 2500;
				Secrets[0] = true;
				Console.ReadLine();
				Console.WriteLine("");
				
			} else if (Answer == "ClayBestTester" && !Secrets[1]) {
				
				Console.WriteLine("Congratulations, you found a secret and got +25 max health for it");
				PlayerStats.MaxHealth += 25;
				PlayerStats.Health += 25;
				Secrets[1] = true;
				Console.ReadLine();
				Console.WriteLine("");
				
			} else if (Answer == "Math" && !Secrets[2]) {
				
				Console.WriteLine("If you can get ten simple math problems correct, then you will get a reward");
				Secrets[2] = true;
				DungeonGame.MathGame();
				Console.WriteLine("Would you like +10 physical or magic damage for finishing your math homework?");
				Console.WriteLine("1. Physical damage");
				Console.WriteLine("2. Magic damage");
				string MathTemp = Console.ReadLine();
				
				if (MathTemp == "1") {
					
					PlayerStats.PhysicalDamage += 10;
					Console.WriteLine("Congrats, you got +10 physical damaage");
					
				} else if (MathTemp == "2") {
					
					PlayerStats.MagicDamage += 10;
					Console.WriteLine("Congrats, you got +10 magic damaage");
					
				} else {
					
					Console.WriteLine("You didn't choose 1 or 2 so you get no reward");
					
				}
				
				Console.ReadLine();
				Console.WriteLine("");
				
			} else if (Answer == "Dragon" && !Secrets[3]) {
				
				Secrets[3] = true;
				PlayerStats = DungeonGame.DragonGame(PlayerStats);
				
			} else if (Answer == "Hangman" && !Secrets[4]) {
				
				Secrets[4] = true;
				DungeonGame.Hangman();
				Console.WriteLine("You get literally no reward for this one");
			    Console.ReadLine();
			    Console.WriteLine("");
				
			} else {
				
				Console.WriteLine("That was not a given option");
			    Console.ReadLine();
			    Console.WriteLine("");
				
			}
			
		}
	
	}
	
	public static void CheckStats (Stats stats, string Title) {
	
	    Console.WriteLine(Title);
		Console.WriteLine(stats.Guilders + " guilders");
		Console.WriteLine("level " + stats.Level + " with " + stats.XP + " XP");
		Console.WriteLine(stats.PhysicalDefense + " physical defense");
		Console.WriteLine(stats.MagicDefense + " magic defense");
		Console.WriteLine(stats.PhysicalDamage + " physical damage");
		Console.WriteLine(stats.MagicDamage + " magic damage");
		Console.WriteLine(stats.Health + " health out of " + stats.MaxHealth);
		Console.WriteLine(stats.Magic + " magic out of " + stats.MaxMagic);
		Console.WriteLine(stats.Stamina + " stamina out of " + stats.MaxStamina);
		Console.WriteLine("Enter any key to continue");
		Console.ReadLine();
		Console.WriteLine("");

	}
	
	public static Stats Shop (Stats stats) {
		
		for (int S = 0; S == 0; S += 0) {
			
			Console.WriteLine("What would you like to buy? You have " + stats.Guilders + " guilders");
			Console.WriteLine("1. Health upgrades");
			Console.WriteLine("2. Defense upgrades");
			Console.WriteLine("3. Attack upgrades");
			Console.WriteLine("4. A way to leave the store");
			string Answer = Console.ReadLine();
			Console.WriteLine("");
			
			for (int s = 0; s == 0; s += 0) {
				
				if (Answer == "1") {
					
					Console.WriteLine("What health upgrade would you like to buy? You have " + stats.Guilders + " guilders");
					Console.WriteLine("1. +10 health, 100 guilders");
					Console.WriteLine("2. +25 health, 200 guilders");
					Console.WriteLine("3. +100 health, 750 guilders");
					Console.WriteLine("4. Get healed, 10 guilders");
					Console.WriteLine("5. Go back");
					string Buy = Console.ReadLine();
					Console.WriteLine("");
					
					if (Buy == "1") {
						
						if (stats.Guilders >= 100) {
							
							stats.Guilders -= 100;
							stats.MaxHealth += 10;
							stats.Health += 10;
							Console.WriteLine("You have successfully upgraded your health by 10");
							
						} else {
							
							Console.WriteLine("You cannot afford this upgrade");
							
						}
						
						Console.WriteLine("");
						
					} else if (Buy == "2") {
						
						if (stats.Guilders >= 200) {
							
							stats.Guilders -= 200;
							stats.MaxHealth += 25;
							stats.Health += 25;
							Console.WriteLine("You have successfully upgraded your health by 10");
							
						} else {
							
							Console.WriteLine("You cannot afford this upgrade");
							
						}
						
					} else if (Buy == "3") {
						
						if (stats.Guilders >= 750) {
							
							stats.Guilders -= 750;
							stats.MaxHealth += 100;
							stats.Health += 100;
							Console.WriteLine("You have successfully upgraded your health by 100");
							
						} else {
							
							Console.WriteLine("You cannot afford this upgrade");
							
						}
						
					} else if (Buy == "4") {
						
						if (stats.Guilders >= 10) {
							
							stats.Guilders -= 10;
							stats = DungeonGame.Heal(stats);
							Console.WriteLine("You have successfully healed yourself");
							
						} else {
							
							Console.WriteLine("You cannot afford this upgrade");
							
						}
						
					} else if (Buy == "5") {
						
						s++;
						
					} else {
						
						Console.WriteLine("That was not a given option");			
						Console.ReadLine();
						Console.WriteLine("");
					}
						
				} else if (Answer == "2") {
					
					Console.WriteLine("What health upgrade would you like to buy? You have " + stats.Guilders + " guilders");
					Console.WriteLine("1. +1 physical defense, 100 guilders");
					Console.WriteLine("2. +3 physical defense, 200 guilders");
					Console.WriteLine("3. +10 physical defense, 750 guilders");
					Console.WriteLine("4. +1 magic defense, 100 guilders");
					Console.WriteLine("5. +3 magic defense, 200 guilders");
					Console.WriteLine("6. +10 magic defense, 750 guilders");
					Console.WriteLine("7. Go back");
					string Buy = Console.ReadLine();
					Console.WriteLine("");
					
					if (Buy == "1") {
						
						if (stats.Guilders >= 100) {
							
							stats.Guilders -= 100;
							stats.PhysicalDefense += 1;
							Console.WriteLine("You successfully upgraded your physical defense by 1");
							
						} else {
							
							Console.WriteLine("You cannot afford this upgrade");
							
						}
						
					} else if (Buy == "2") {
						
						if (stats.Guilders >= 200) {
							
							stats.Guilders -= 200;
							stats.PhysicalDefense += 3;
							Console.WriteLine("You successfully upgraded your physical defense by 3");
							
						} else {
							
							Console.WriteLine("You cannot afford this upgrade");
							
						}
						
					} else if (Buy == "3") {
						
						if (stats.Guilders >= 750) {
							
							stats.Guilders -= 750;
							stats.PhysicalDefense += 10;
							Console.WriteLine("You successfully upgraded your physical defense by 10");
							
						} else {
							
							Console.WriteLine("You cannot afford this upgrade");
							
						}
						
					} else if (Buy == "4") {
						
						if (stats.Guilders >= 100) {
							
							stats.Guilders -= 100;
							stats.MagicDefense += 1;
							Console.WriteLine("You successfully upgraded your magic defense by 1");
							
						} else {
							
							Console.WriteLine("You cannot afford this upgrade");
							
						}
						
					} else if (Buy == "5") {
						
						if (stats.Guilders >= 200) {
							
							stats.Guilders -= 200;
							stats.MagicDefense += 3;
							Console.WriteLine("You successfully upgraded your magic defense by 3");
							
						} else {
							
							Console.WriteLine("You cannot afford this upgrade");
							
						}
						
					} else if (Buy == "6") {
						
						if (stats.Guilders >= 750) {
							
							stats.Guilders -= 750;
							stats.MagicDefense += 10;
							Console.WriteLine("You successfully upgraded your magic defense by 10");
							
						} else {
							
							Console.WriteLine("You cannot afford this upgrade");
							
						}
						
					} else if (Buy == "7") {
						
						s++;
						
					} else {
						
						Console.WriteLine("That was not a given option");
						Console.ReadLine();
						Console.WriteLine("");
						
					}
					
				} else if (Answer == "3") {
					
					Console.WriteLine("What attack upgrade would you like to buy? You have " + stats.Guilders + " guilders");
					Console.WriteLine("1. +1 physical attack, 100 guilders");
					Console.WriteLine("2. +3 physical attack, 200 guilders");
					Console.WriteLine("3. +10 physical attack, 750 guilders");
					Console.WriteLine("4. +1 magic attack, 100 guilders");
					Console.WriteLine("5. +3 magic attack, 200 guilders");
					Console.WriteLine("6. +10 magic attack, 750 guilders");
					Console.WriteLine("7. +10 magic, 100 guilders");
					Console.WriteLine("8. +25 magic, 200 guilders");
					Console.WriteLine("9. +100 magic, 750 guilders");
					Console.WriteLine("10. +10 stamina, 100 guilders");
					Console.WriteLine("11. +25 stamina, 200 guilders");
					Console.WriteLine("12. +100 stamina, 750 guilders");
					Console.WriteLine("13. Go back");
					string Buy = Console.ReadLine();
					Console.WriteLine("");
					
					if (Buy == "1") {
						
						if (stats.Guilders >= 100) {
							
							stats.Guilders -= 100;
							stats.PhysicalDamage += 1;
							Console.WriteLine("You successfully upgraded your physical attack by 1");
							
						} else {
							
							Console.WriteLine("You cannot afford this upgrade");
							
						}
						
					} else if (Buy == "2") {
						
						if (stats.Guilders >= 200) {
							
							stats.Guilders -= 200;
							stats.PhysicalDamage += 3;
							Console.WriteLine("You successfully upgraded your physical attack by 3");
							
						} else {
							
							Console.WriteLine("You cannot afford this upgrade");
							
						}
						
					} else if (Buy == "3") {
						
						if (stats.Guilders >= 750) {
							
							stats.Guilders -= 750;
							stats.PhysicalDamage += 10;
							Console.WriteLine("You successfully upgraded your physical attack by 10");
							
						} else {
							
							Console.WriteLine("You cannot afford this upgrade");
							
						}
						
					} else if (Buy == "4") {
						
						if (stats.Guilders >= 100) {
							
							stats.Guilders -= 100;
							stats.MagicDamage += 1;
							Console.WriteLine("You successfully upgraded your magic attack by 1");
							
						} else {
							
							Console.WriteLine("You cannot afford this upgrade");
							
						}
						
					} else if (Buy == "5") {
						
						if (stats.Guilders >= 200) {
							
							stats.Guilders -= 200;
							stats.MagicDamage += 3;
							Console.WriteLine("You successfully upgraded your magic attack by 3");
							
						} else {
							
							Console.WriteLine("You cannot afford this upgrade");
							
						}
						
					} else if (Buy == "6") {
						
						if (stats.Guilders >= 750) {
							
							stats.Guilders -= 750;
							stats.MagicDamage += 10;
							Console.WriteLine("You successfully upgraded your magic attack by 10");
							
						} else {
							
							Console.WriteLine("You cannot afford this upgrade");
							
						}
						
					} else if (Buy == "7") {
						
						if (stats.Guilders >= 100) {
							
							stats.Guilders -= 100;
							stats.MaxMagic += 10;
							stats.Magic += 10;
							Console.WriteLine("You successfully upgraded your magic by 10");
							
						} else {
							
							Console.WriteLine("You cannot afford this upgrade");
							
						}
						
					} else if (Buy == "8") {
						
						if (stats.Guilders >= 200) {
							
							stats.Guilders -= 200;
							stats.MaxMagic += 25;
							stats.Magic += 25;
							Console.WriteLine("You successfully upgraded your magic by 25");
							
						} else {
							
							Console.WriteLine("You cannot afford this upgrade");
							
						}
						
					} else if (Buy == "9") {
						
						if (stats.Guilders >= 750) {
							
							stats.Guilders -= 750;
							stats.MaxMagic += 100;
							stats.Magic += 100;
							Console.WriteLine("You successfully upgraded your magic by 100");
							
						} else {
							
							Console.WriteLine("You cannot afford this upgrade");
							
						}
						
					} else if (Buy == "10") {
						
						if (stats.Guilders >= 100) {
							
							stats.Guilders -= 100;
							stats.MaxStamina += 10;
							stats.Stamina += 10;
							Console.WriteLine("You successfully upgraded your stamina by 10");
							
						} else {
							
							Console.WriteLine("You cannot afford this upgrade");
							
						}
						
					} else if (Buy == "11") {
						
						if (stats.Guilders >= 200) {
							
							stats.Guilders -= 200;
							stats.MaxStamina += 25;
							stats.Stamina += 25;
							Console.WriteLine("You successfully upgraded your stamina by 25");
							
						} else {
							
							Console.WriteLine("You cannot afford this upgrade");
							
						}
						
					} else if (Buy == "12") {
						
						if (stats.Guilders >= 750) {
							
							stats.Guilders -= 750;
							stats.MaxStamina += 100;
							stats.Stamina += 100;
							Console.WriteLine("You successfully upgraded your stamina by 100");
							
						} else {
							
							Console.WriteLine("You cannot afford this upgrade");
							
						}
						
					} else if (Buy == "13") {
						
						s++;
						
					} else {
						
						Console.WriteLine("That was not a given option");
						Console.ReadLine();
						Console.WriteLine("");
						
					}
					
				} else if (Answer == "4") {
					
					Console.WriteLine("Glad to see you leave");
					Console.ReadLine();
					Console.WriteLine("");
					s++;
					S++;
					break;
					
				} else {
					
					Console.WriteLine("Not a given option");
					Console.ReadLine();
					Console.WriteLine("");
					s++;
					
				}
				
			}
			
		}
		
		return stats;
	
	}
	
	public static Stats BlackMarket (Stats stats, bool[] Secrets) {
		
		for (int S = 0; S == 0; S += 0) {
	
			Console.WriteLine("Welcome to the black market, what would you like to buy? You have " + stats.Guilders + " guilders");
			Console.WriteLine("1. Secrets");
			Console.WriteLine("2. Ridiculous upgrades");
			Console.WriteLine("3. A way to leave");
			string TempAnswer = Console.ReadLine();
			Console.WriteLine("");
			
			if (TempAnswer == "1") {
				
				int SecretsHad = 0;
				
				for (int x = 0; x < Secrets.Length; x++) {
					
					if (Secrets[x]) {
						
						SecretsHad ++;
						
					}
					
				}
				
				string TempS = "s";
				
				if (SecretsHad == 1) {
					
					TempS = "";
					
				}
				
				for (int s = 0; s == 0; s += 0) {
					
					Console.WriteLine("You have discovered " + SecretsHad + " secret"  + TempS + " out of " + Secrets.Length + " You have " + stats.Guilders + " guilders");
					
					if (Secrets[0]) {
						
						Console.WriteLine("1. You have already discover the Egg secret");
						
					} else {
						
						Console.WriteLine("1. ?????????? - 250 guilders");
						
					}
					
					if (Secrets[1]) {
						
						Console.WriteLine("2. You have already discover the Clay secret");
						
					} else {
						
						Console.WriteLine("2. ?????????? - 250 guilders");
						
					}
					
					if (Secrets[2]) {
						
						Console.WriteLine("3. You have already discover the Math secret");
						
					} else {
						
						Console.WriteLine("3. ?????????? - 250 guilders");
						
					}
					
					if (Secrets[3]) {
						
						Console.WriteLine("4. You have already discover the Dragon secret");
						
					} else {
						
						Console.WriteLine("4. ?????????? - 250 guilders");
						
					}
					
					if (Secrets[4]) {
						
						Console.WriteLine("5. You have already discover the Hangman secret");
						
					} else {
						
						Console.WriteLine("5. ?????????? - 250 guilders");
						
					}
					
					Console.WriteLine("6. Go back");
					TempAnswer = Console.ReadLine();
					Console.WriteLine("");
					
					if (TempAnswer == "1") {
						
						if (Secrets[0]) {
							
							Console.WriteLine("You have already discovered this secret");
							
						} else {
							
							if (stats.Guilders >= 250) {
								
								stats.Guilders -= 250;
								Console.WriteLine("To get this secret you must type 'Egg' at the home screen");
								Console.WriteLine("");
								Console.ReadLine();
								
							} else {
								
								Console.WriteLine("You cannot afford this upgrade");
								
							}
							
						}
						
					} else if (TempAnswer == "2") {
						
						if (Secrets[1]) {
							
							Console.WriteLine("You have already discovered this secret");
							
						} else {
							
							if (stats.Guilders >= 250) {
								
								stats.Guilders -= 250;
								Console.WriteLine("To get this secret you must type 'ClayBestTester' at the home screen");
								Console.WriteLine("");
								Console.ReadLine();
								
							} else {
								
								Console.WriteLine("You cannot afford this upgrade");
								
							}
						
						}
						
					} else if (TempAnswer == "3") {
						
						if (Secrets[2]) {
							
							Console.WriteLine("You have already discovered this secret");
							
						} else {
							
							if (stats.Guilders >= 250) {
								
								stats.Guilders -= 250;
								Console.WriteLine("To get this secret you must type 'Math' at the home screen");
								Console.WriteLine("");
								Console.ReadLine();
								
							} else {
								
								Console.WriteLine("You cannot afford this upgrade");
								
							}
							
						}
						
					} else if (TempAnswer == "4") {
						
						if (Secrets[3]) {
							
							Console.WriteLine("You have already discovered this secret");
							
						} else {
							
							if (stats.Guilders >= 250) {
								
								stats.Guilders -= 250;
								Console.WriteLine("To get this secret you must type 'Dragon' at the home screen");
								Console.WriteLine("");
								Console.ReadLine();
								
							} else {
								
								Console.WriteLine("You cannot afford this upgrade");
								
							}
							
						}
						
					} else if (TempAnswer == "5") {
						
						if (Secrets[4]) {
							
							Console.WriteLine("You have already discovered this secret");
							
						} else {
							
							if (stats.Guilders >= 250) {
								
								stats.Guilders -= 250;
								Console.WriteLine("To get this secret you must type 'Hangman' at the home screen");
								Console.WriteLine("");
								Console.ReadLine();
								
							} else {
								
								Console.WriteLine("You cannot afford this upgrade");
								
							}
							
						}
						
					} else if (TempAnswer == "6") {
						
						Console.WriteLine("Bye");
						Console.ReadLine();
						Console.WriteLine("");
						s++;
						break;
						
					} else {
						
						Console.WriteLine("That was not a given option.");
						
					}
					
				}
				
			} else if (TempAnswer == "2") {
				
				for (int s = 0; s == 0; s += 0) {
					
					Console.WriteLine("What would you like to buy? You have " + stats.Guilders + " guilders");
					Console.WriteLine("1. +250 health, 1000 guilders");
					Console.WriteLine("2. +25 physical defense, 1000 guilders");
					Console.WriteLine("3. +25 magic defense, 1000 guilders");
					Console.WriteLine("4. +25 physical damage, 1000 guilders");
					Console.WriteLine("5. +25 magic damage, 1000 guilders");
					Console.WriteLine("6. +250 stamina, 1000 guilders");
					Console.WriteLine("7. +250 magic, 1000 guilders");
					Console.WriteLine("8. Leave the store");
					TempAnswer = Console.ReadLine();
					Console.WriteLine("");
					
					if (TempAnswer == "1") {
						
						if (stats.Guilders >= 1000) {
							
							stats.Guilders -= 1000;
							stats.MaxHealth += 250;
							stats.Health += 250;
							Console.WriteLine("You have successfully upgraded you health by 250");
							Console.ReadLine();
							Console.WriteLine("");
							
						} else {
							
							Console.WriteLine("You cannot afford this upgrade");
							Console.ReadLine();
							Console.WriteLine("");
							
						}
						
					} else if (TempAnswer == "2") {
						
						if (stats.Guilders >= 1000) {
							
							stats.Guilders -= 1000;
							stats.PhysicalDefense += 25;
							Console.WriteLine("You have successfully upgraded you physical defense by 25");
							Console.ReadLine();
							Console.WriteLine("");
							
						} else {
							
							Console.WriteLine("You cannot afford this upgrade");
							Console.ReadLine();
							Console.WriteLine("");
							
						}
						
					} else if (TempAnswer == "3") {
						
						if (stats.Guilders >= 1000) {
							
							stats.Guilders -= 1000;
							stats.MagicDefense += 25;
							Console.WriteLine("You have successfully upgraded you magic defense by 25");
							Console.ReadLine();
							Console.WriteLine("");
							
						} else {
							
							Console.WriteLine("You cannot afford this upgrade");
							Console.ReadLine();
							Console.WriteLine("");
							
						}
						
					} else if (TempAnswer == "4") {
						
						if (stats.Guilders >= 1000) {
							
							stats.Guilders -= 1000;
							stats.PhysicalDamage += 25;
							Console.WriteLine("You have successfully upgraded you physical damage by 25");
							Console.ReadLine();
							Console.WriteLine("");
							
						} else {
							
							Console.WriteLine("You cannot afford this upgrade");
							Console.ReadLine();
							Console.WriteLine("");
							
						}
						
					} else if (TempAnswer == "5") {
						
						if (stats.Guilders >= 1000) {
							
							stats.Guilders -= 1000;
							stats.MagicDamage += 25;
							Console.WriteLine("You have successfully upgraded you magic damage by 25");
							Console.ReadLine();
							Console.WriteLine("");
							
						} else {
							
							Console.WriteLine("You cannot afford this upgrade");
							Console.ReadLine();
							Console.WriteLine("");
							
						}
						
					} else if (TempAnswer == "6") {
						
						if (stats.Guilders >= 1000) {
							
							stats.Guilders -= 1000;
							stats.Stamina += 250;
							Console.WriteLine("You have successfully upgraded you stamina by 250");
							Console.ReadLine();
							Console.WriteLine("");
							
						} else {
							
							Console.WriteLine("You cannot afford this upgrade");
							Console.ReadLine();
							Console.WriteLine("");
							
						}
						
					} else if (TempAnswer == "7") {
						
						if (stats.Guilders >= 1000) {
							
							stats.Guilders -= 1000;
							stats.Magic += 250;
							Console.WriteLine("You have successfully upgraded you magic by 250");
							Console.ReadLine();
							Console.WriteLine("");
							
						} else {
							
							Console.WriteLine("You cannot afford this upgrade");
							Console.ReadLine();
							Console.WriteLine("");
							
						}
						
					} else if (TempAnswer == "8") {
						
						Console.WriteLine("Bye");
						Console.ReadLine();
						Console.WriteLine("");
						s++;
						break;
						
					} else {
						
						Console.WriteLine("Not a given option");
						TempAnswer = Console.ReadLine();
						Console.WriteLine("");
						
					}
						
				}
				
			} else if (TempAnswer == "3") {
				
				S++;
				break;
				
			} else {
				
				Console.WriteLine("Not a given option");
				
			}
	
		}
		
		Console.WriteLine("Bye");
		Console.ReadLine();
		Console.WriteLine("");
		return stats;
		
	}
	
	public static Stats DungeonSearch (Stats stats) {
		
		int MonstersKilled = 0;
		
		Console.WriteLine("Searching for dungeon");
		Dungeon dungeon;
		dungeon.Level = stats.Level;
		dungeon.Monsters = DungeonGame.RNDM(1 + dungeon.Level, 4 * dungeon.Level);
		dungeon.GuilderReward = DungeonGame.RNDM(250, 500 * dungeon.Level);
		
		Console.WriteLine("Level " + dungeon.Level + " dungeon found");
		Console.WriteLine(dungeon.Monsters + " monsters in the dungeon");
		Console.WriteLine("Are you ready? (Y/N) (Your choice has no effect on what happens)");
		Console.ReadLine();
		Console.WriteLine("");
		
		for (int x = 0; x < dungeon.Monsters; x++) {
			
			Stats MonsterStats;
			
			MonsterStats.Guilders = DungeonGame.RNDM(10, 25 * dungeon.Level);
			
			MonsterStats.Level = dungeon.Level;
			MonsterStats.XP = DungeonGame.RNDM(2 + dungeon.Level, 4 * dungeon.Level);
			
			MonsterStats.PhysicalDefense = DungeonGame.RNDM(2 + dungeon.Level, 3 * dungeon.Level);
			MonsterStats.PhysicalDamage = DungeonGame.RNDM(4 + dungeon.Level, 5 * dungeon.Level);
			
			MonsterStats.MagicDefense = DungeonGame.RNDM(2 + dungeon.Level, 3 * dungeon.Level);
			MonsterStats.MagicDamage = DungeonGame.RNDM(4 + dungeon.Level, 5 * dungeon.Level);
			
			MonsterStats.MaxHealth = DungeonGame.RNDM(9 + dungeon.Level, 25 * dungeon.Level);
			MonsterStats.Health = MonsterStats.MaxHealth;
			
			MonsterStats.MaxMagic = DungeonGame.RNDM(25 + dungeon.Level, 50 * dungeon.Level);
			MonsterStats.Magic = MonsterStats.MaxMagic;
			
			MonsterStats.MaxStamina = DungeonGame.RNDM(25 + dungeon.Level, 50 * dungeon.Level);
			MonsterStats.Stamina = MonsterStats.MaxStamina;
			
			DungeonGame.CheckStats(MonsterStats, "Monster Stats");
			
			for (int y = 0; y == 0; y += 0) {
				
				float DamageTemp;
			    	
			    if (stats.Health <= 0) {
			    	
			    	y++;
			    	break;
			    	
			    }
			    
			    if (MonstersKilled > 0) {
			    	
			    	string TempS;
			    	
			    	if (MonstersKilled == 1) {
			    		
			    		TempS = "";
			    		
			    	} else {
			    		
			    		TempS = "s";
			    		
			    	}
			    	
			    	Console.WriteLine("You have killed " + MonstersKilled + " monster" + TempS + " out of " + dungeon.Monsters + " monsters");
			    	
			    }
			    
                for (int z = 0; z == 0; z += 0) {
                    
                    if (stats.Health <= 0) {
	    				
	    				z++;
	    				break;
	    				
	    			}
                    
                	Console.WriteLine("What would you like to do?\nYou have " + stats.Health + " health and the monster has " + MonsterStats.Health + " health");
        			Console.WriteLine("1. Physical attack for " + stats.PhysicalDamage + " and 1 stamina, you have " + stats.Stamina + " stamina");
        			Console.WriteLine("2. Magical attack for " + stats.MagicDamage + " and 1 magic, you have " + stats.Magic + " magic");
        			Console.WriteLine("3. Relax and heal " + stats.Level * 5 + " health for 1 magic");
        			Console.WriteLine("4. Check your stats");
        			Console.WriteLine("5. Check the monsters stats");
        			Console.WriteLine("6. Die (for use in a pinch)");
        			string Answer = Console.ReadLine();
        			Console.WriteLine("");
        			
        			if (Answer == "1") {
        				
        				if (stats.Stamina > 0) {
        					
        					DamageTemp = stats.PhysicalDamage - MonsterStats.PhysicalDefense/2;
        					
        					if (DamageTemp < 1) {
        						
        						DamageTemp = 1;
        						
        					}
        					
	            			MonsterStats.Health -= DamageTemp;
	            			Console.WriteLine("You did " + DamageTemp + " damage to the monster");
	            			stats.Stamina --;
	        			    z++;	
        					
        				} else {
        					
        					Console.WriteLine("You don't have enough stamina");
        					
        				}
        			
        			} else if (Answer == "2") {
        				
        				if (stats.Magic > 0) {
	        					
	        				DamageTemp = stats.MagicDamage - MonsterStats.MagicDefense/2;
	        				
	        				if (DamageTemp < 1) {
	        					
	        					DamageTemp = 1;
	        					
	        				}
	        				
	            			MonsterStats.Health -= DamageTemp;
	            			Console.WriteLine("You did " + DamageTemp + " damage to the monster");
	            			stats.Magic --;
	        			    z++;
        					
        				} else {
        					
        					Console.WriteLine("You don't have enough magic");
        					
        				}
        			
        			} else if (Answer == "3") {
        				
        				if (stats.Magic > 0) {
        			
        					stats.Magic --;
	        				DamageTemp = stats.Level * 5;
	            			stats.Health += DamageTemp;
	            			Console.WriteLine("You gained " + DamageTemp + " health");
	            			
	            			if (stats.Health > stats.MaxHealth) {
	            			    
	            			    stats.Health = stats.MaxHealth;
	            			    
	            			}
        					
        				} else {
        					
        					Console.WriteLine("You do not have enough magic for healing");
        					
        				}
            			
            			z++;
        			
        			} else if (Answer == "4") {
        				
        				DungeonGame.CheckStats(stats, "Your Stats");
        			
        			} else if (Answer == "5") {
        				
        				DungeonGame.CheckStats(MonsterStats, "Monster Stats");
        			
        			} else if (Answer == "6") {
        				
        				z++;
						stats.Health = 0;
        				break;
        				
        			} else {
        			    
        			    Console.WriteLine("That was not a given option");
        			    Console.ReadLine();
        			    Console.WriteLine("");
        			    
        			}
                    
                }
                
                if (MonsterStats.Health <= 0) {
                    
                    Console.WriteLine("You killed the monster and gained " + MonsterStats.Guilders + " guilders and " + MonsterStats.XP + " XP");
                    
                    if (DungeonGame.RNDM(0, 100) == 50) {
                    	
                    	Console.WriteLine("Congrats, you got this 1 in 100 event");
                    	Console.WriteLine("Try 5 at the beginning, your welcome");
                    	
                    }
                    
                    MonstersKilled++;
                    
                    if (stats.XP >= (stats.Level * 15) + 20) {
                    	
                    	stats.Level++;
                    	stats.XP -= (stats.Level * 15) + 20;
                    	stats = DungeonGame.Heal(stats);
                    	Console.WriteLine("You leveled up to level " + stats.Level + ", congrats");
						Console.ReadLine();
						Console.WriteLine("");
						
                    }
                    
					Console.WriteLine("");
                    stats.Guilders += MonsterStats.Guilders;
                    stats.XP += MonsterStats.XP;
                    y++;
                    
                } else if (!(stats.Health <= 0)) {
		        	
	    			int TempAnswer = DungeonGame.RNDM(1, 3);
	    			
					if (TempAnswer == 1) {
					
	    				if (MonsterStats.Stamina > 0) {
	    					
		    				DamageTemp = MonsterStats.PhysicalDamage - stats.PhysicalDefense/2;
		    				
		    				if (DamageTemp < 1) {
		    					
		    					DamageTemp = 1;
		    					
		    				}
		    				
		        			stats.Health -= DamageTemp;
		        			Console.WriteLine("The monster did " + DamageTemp + " damage to you");
		    				MonsterStats.Stamina --;
	    					
	    				} else {
	    					
	    					Console.WriteLine("The monster did 0 damage to you");
	    					
	    				}
	    			
	    			} else if (TempAnswer == 2) {
					
						if (MonsterStats.Magic > 0) {
								
		    				DamageTemp = MonsterStats.MagicDamage - stats.MagicDefense/2;
		    				
		    				if (DamageTemp < 1) {
		    					
		    					DamageTemp = 1;
		    					
		    				}
		    				
		        			stats.Health -= DamageTemp;
		        			Console.WriteLine("The monster did " + DamageTemp + " damage to you");
		        			MonsterStats.Magic --;
								
						} else {
	    					
	    					Console.WriteLine("The monster did 0 damage to you");
	    					
	    				}
	    			
	    			}
	    			
	    			Console.ReadLine();
					Console.WriteLine("");
			        	
		        }
		        
		        if (stats.Health <= 0) {
		        	
		        	x = dungeon.Monsters;
		        	
		        }
		        
			}
		
		}
		
		if (stats.Health > 0) {
				
			Console.WriteLine("Congratulations, you beat this level " + dungeon.Level + " dungeon with " + dungeon.Monsters + " monsters and got " + dungeon.GuilderReward + " guilders for it");
			stats.Guilders += dungeon.GuilderReward;
			Console.ReadLine();
			Console.WriteLine("");
				
		}
		
		return stats;
	
	}
	
	public struct Stats {
		
		public int Guilders;
		public int Level;
		public int XP;
		
		public int PhysicalDefense;
		public int PhysicalDamage;
		
		public int MagicDefense;
		public int MagicDamage;
		
		public int MaxHealth;
		public float Health;
		
		public int MaxMagic;
		public float Magic;
		
		public int MaxStamina;
		public float Stamina;
		
	}
	
	public struct Dungeon {
		
		public int Level;
		public int Monsters;
		public int GuilderReward;
		
	}
	
	private static readonly Random getrandom = new Random();
	
	public static int RNDM (int min, int max) {
        
		lock (getrandom) {
			
			return getrandom.Next(min, max);
			
		}
		
	}
	
	public static void MathGame() {
		
		int A;
		int B;
		int C;
		
		for (int i = 0; i < 10; i += 0){
			
			A = DungeonGame.RNDM(1, 10);
			B = DungeonGame.RNDM(1, 10);
			C = A + B;
			
			Console.WriteLine("What is " + A + " + " + B + "?");
			
			String Answer = Console.ReadLine();
			
			if(Answer == C.ToString()) {
				
				Console.WriteLine("Wow good job, you know that " + A + " + " + B  + " = " + C);
				i++;
				
			} else {
				
				Console.WriteLine("Wrong, " + A + " + " + B  + " = " + C);
				
			}
			
			Console.WriteLine("");
			
		}
    
	}
	
	public static Stats DragonGame (Stats stats) {
            
        Console.WriteLine("You are a dragon");
        Console.WriteLine("1. Murder everything in sight.");
        Console.WriteLine("2. Eat apples and sleep");
		
		int[] Choice = new int[2];
		
		for (int C = 0; C == 0; C += 0) {//Choice 1
			
			String ChoiceTemp = Console.ReadLine();
			
			if (ChoiceTemp == "1") {
				
				Console.WriteLine("That wasn't very nice.");
				Console.WriteLine("You're bored and don't know what to do.");	
				Console.WriteLine("1. Go somewhere else and murder more innocents.");
				Console.WriteLine("2. Eat apples and sleep");
				C ++;
				Choice[0] = 1;
				
			} else if (ChoiceTemp == "2") {
				
				Console.WriteLine("Apples taste better than people.");
				Console.WriteLine("You wake up to some soldiers bothering you");	
				Console.WriteLine("1. Kill them for no good reason");
				Console.WriteLine("2. Tell them that you're cool and sleep again");
				C ++;
				Choice[0] = 2;
				
			} else {
				
				Console.WriteLine("Not a given choice");
				
			}
			
		}
		
		for (int C = 0; C == 0; C += 0) {//Choice2
			
			String ChoiceTemp = Console.ReadLine();
			
			if (Choice[0] == 1) {
				
				if (ChoiceTemp == "1") {
					
					Console.WriteLine("That was even meaner.");
					Console.WriteLine("What are you going to do now you not nice dragon?");
					Console.WriteLine("1. Kill anything that moves.");
					Console.WriteLine("2. Eat an apple.");
					C ++;
					Choice[1] = 1;
					
				} else if (ChoiceTemp == "2") {
					
					Console.WriteLine("Apples taste better than people.");
					Console.WriteLine("Soldiers in the nearest city want you dead.");
					Console.WriteLine("1. Kill any soldiers that come near you.");
					Console.WriteLine("2. Eat more apples.");
					C ++;
					Choice[1] = 2;
					
				} else {
					
					Console.WriteLine("Not a given choice");
					
				}
				
			}
			
			if (Choice[0] == 2) {
				
				if (ChoiceTemp == "1") {
					
					Console.WriteLine("You shouldn't do that.");
					Console.WriteLine("1. Murder all of the citizens of that town");
					Console.WriteLine("2. Eat apples");
					C ++;
					Choice[1] = 1;
					
				} else if (ChoiceTemp == "2") {
					
					Console.WriteLine("The soldiers stop bothering you and nothing else important happens.");
					Console.WriteLine("1. Murder all of the citizens of that town");
					Console.WriteLine("2. Eat apples");
					C ++;
					Choice[1] = 2;
					
				} else {
					
					Console.WriteLine("Not a given choice");
					
				}
				
			}
			
		}
		
		for (int C = 0; C == 0; C += 0) {//Choice 3
			
			String ChoiceTemp = Console.ReadLine();
			
			if (Choice[0] == 1) {
				
				if(Choice[1] == 1) {
					
					if (ChoiceTemp == "1") {
						
						Console.WriteLine("You are a bad egg.");
						Console.WriteLine("You are also the only livng creature on Earth now so you die a boring death.");
						Console.WriteLine("For being so strong (by killing everything) you get +10 physical damage");
						stats.PhysicalDamage += 10;
						C++;
						
					} else if (ChoiceTemp == "2") {
						
						Console.WriteLine("Apples taste better than people.");
						Console.WriteLine("You get killed by gaurds while eating apples.");
						Console.WriteLine("For giving up and getting killed by gaurds, you get +10 health");
						stats.MaxHealth += 10;
						stats.Health += 10;
						C++;
						
					} else {
					
						Console.WriteLine("Not a given choice");
					
					}
					
				} else if(Choice[1] == 2) {
					
					if (ChoiceTemp == "1") {
						
						Console.WriteLine("You end up killing all of the militia in that city.");
						Console.WriteLine("You now rule the world with everone afraid of you.");
						Console.WriteLine("You also get as many apples as you want whenever you want.");
						Console.WriteLine("For being so strong and ruling the world, you get +10 physical damage and +10 physical defense");
						stats.PhysicalDamage += 10;
						stats.PhysicalDefense += 10;
						C++;
						
					} else if (ChoiceTemp == "2") {
						
						Console.WriteLine("Apples taste better than people.");
						Console.WriteLine("Gaurds kill you while you are eating apples.");
						Console.WriteLine("For giving up and getting killed by gaurds, you get +10 health");
						stats.MaxHealth += 10;
						stats.Health += 10;
						
						C++;
						
					} else {
					
						Console.WriteLine("Not a given choice");
					
					}
					
				}
				
			} else if (Choice[0] == 2) {
				
				if(Choice[1] == 1) {
					
					if (ChoiceTemp == "1") {
						
						Console.WriteLine("After killing all of the citizens of that town, you get bored and sleep.");
						Console.WriteLine("Gaurds from another town kill you in your sleep.");
						Console.WriteLine("For giving up and getting killed by gaurds, you get +10 health");
						stats.MaxHealth += 10;
						stats.Health += 10;
						C++;
						
					} else if (ChoiceTemp == "2") {
						
						Console.WriteLine("Apples taste better than people.");
						Console.WriteLine("You get killed by gaurds from another town while you are eating.");
						Console.WriteLine("For giving up and getting killed by gaurds, you get +10 health");
						stats.MaxHealth += 10;
						stats.Health += 10;
						C++;
						
					} else {
					
						Console.WriteLine("Not a given choice");
					
					}
					
				} else if(Choice[1] == 2) {
					
					if (ChoiceTemp == "1") {
						
						Console.WriteLine("After killig everyone in the town more militia come and attack.");
						Console.WriteLine("You end up killing all militia and rule the world with everyone spooked of you.");
						Console.WriteLine("For being strong and killing all the gaurds, you get +3 physical damage");
						stats.PhysicalDamage += 10;
						C++;
						
					} else if (ChoiceTemp == "2") {
						
						Console.WriteLine("You are a good dragon");
						Console.WriteLine("Everyone around the world knows you as a nice dragon.");
						Console.WriteLine("For being a nice dragon and eating apples, you get +100 health");
						stats.MaxHealth += 100;
						stats.Health += 100;
						C++;
						
					} else {
					
						Console.WriteLine("Not a given choice");
					
					}
					
				}
				
			}
		
		}
		
		Console.WriteLine("The End");
		Console.ReadLine();
		return stats;	
		
	}
	
	public static void Hangman () {
		
		int Length = 278;
		string[] Words = new string[Length];
		Words[0] = "AWKWARD";
		Words[1] = "BAGPIPES";
		Words[2] = "BANJO";
		Words[3] = "BUNGLER";
		Words[4] = "CROQUET";
		Words[5] = "CRYPT";
		Words[6] = "CROISSANT";
		Words[7] = "DWARVES";
		Words[8] = "FERVID";
		Words[9] = "FISHHOOK";
		Words[10] = "FJORD";
		Words[11] = "GAZEBO";
		Words[12] = "GYPSY";
		Words[13] = "HAIKU";
		Words[14] = "HAPHAZARD";
		Words[15] = "HYPHEN";
		Words[16] = "IVORY";
		Words[17] = "JAZZY";
		Words[18] = "JIFFY";
		Words[19] = "JINX";
		Words[20] = "JUKEBOX";
		Words[21] = "KAYAK";
		Words[22] = "KIOSK";
		Words[23] = "KLUTZ";
		Words[24] = "MEMENTO";
		Words[25] = "MYSTIFY";
		Words[26] = "NUMBSKULL";
		Words[27] = "OSTRACIZE";
		Words[28] = "OXYGEN";
		Words[29] = "PAJAMA";
		Words[30] = "PHLEGM";
		Words[31] = "PIXEL";
		Words[32] = "POLKA";
		Words[33] = "QUAD";
		Words[34] = "QUIP";
		Words[35] = "RHYTHMIC";
		Words[36] = "ROGUE";
		Words[37] = "SPHINX";
		Words[38] = "SQUAWK";
		Words[39] = "SWIVEL";
		Words[40] = "TOADY";
		Words[41] = "TWELFTH";
		Words[42] = "UNZIP";
		Words[43] = "WAXY";
		Words[44] = "WILDEBEEST";
		Words[45] = "YACHT";
		Words[46] = "ZEALOUS";
		Words[47] = "ZIGZAG";
		Words[48] = "ZIPPY";
		Words[49] = "ZOMBIE";
		Words[50] = "ABRUPTLY";
		Words[51] = "ABSURD";
		Words[52] = "ABYSS";
		Words[53] = "AFFIX";
		Words[54] = "ASKEW";
		Words[55] = "AVENUE";
		Words[56] = "AXIOM";
		Words[57] = "AZURE";
		Words[58] = "BANDWAGON";
		Words[59] = "BAYOU";
		Words[60] = "BEEKEEPER";
		Words[61] = "BLITZ";
		Words[62] = "BLIZZARD";
		Words[63] = "BOGGLE";
		Words[64] = "BOOKWORM";
		Words[65] = "BOXCAR";
		Words[66] = "BOXFUL";
		Words[67] = "BUCKAROO";
		Words[68] = "BUFFALO";
		Words[69] = "BUFFOON";
		Words[70] = "BUXOM";
		Words[71] = "BUZZARD";
		Words[72] = "BUZZING";
		Words[73] = "BUZZWORDS";
		Words[74] = "CALIPH";
		Words[75] = "COBWEB";
		Words[76] = "COCKINESS";
		Words[77] = "CURACAO";
		Words[78] = "CYCLE";
		Words[79] = "DIZZYING";
		Words[80] = "DUPLEX";
		Words[81] = "EMBEZZLE";
		Words[82] = "EQUIP";
		Words[83] = "ESPIONAGE";
		Words[84] = "EXODUS";
		Words[85] = "FAKING";
		Words[86] = "FIXABLE";
		Words[87] = "FLAPJACK";
		Words[88] = "FLOPPING";
		Words[89] = "FLUFFINESS";
		Words[90] = "FLYBY";
		Words[91] = "FOXGLOVE";
		Words[92] = "FRAZZLED";
		Words[93] = "FRIZZLED";
		Words[94] = "FUCHSIA";
		Words[95] = "FUNNY";
		Words[96] = "GABBY";
		Words[97] = "GALAXY";
		Words[98] = "GALVANIZE";
		Words[99] = "GIAOUR";
		Words[100] = "GIZMO";
		Words[101] = "GLOWWORM";
		Words[102] = "GLYPH";
		Words[103] = "GNARLY";
		Words[104] = "GOSSIP";
		Words[105] = "GROGGINESS";
		Words[106] = "ICEBOX";
		Words[107] = "INJURY";
		Words[108] = "IVY";
		Words[109] = "JACKPOT";
		Words[110] = "JAUNDICE";
		Words[111] = "JAWBREAKER";
		Words[112] = "JAYWALK";
		Words[113] = "JAZZIEST";
		Words[114] = "JELLY";
		Words[115] = "JIGSAW";
		Words[116] = "JINX";
		Words[117] = "JOCKEY";
		Words[118] = "JOGGING";
		Words[119] = "JOKING";
		Words[120] = "JOVIAL";
		Words[121] = "JOYFUL";
		Words[122] = "JUICY";
		Words[123] = "JUKEBOX";
		Words[124] = "JUMBO";
		Words[125] = "KAYAK";
		Words[126] = "KAZOO";
		Words[127] = "KEYHOLE";
		Words[128] = "KHAKI";
		Words[129] = "KILOBYTE";
		Words[130] = "KIOSK";
		Words[131] = "KITSCH";
		Words[132] = "KIWIFRUIT";
		Words[133] = "KLUTZ";
		Words[134] = "KNAPSACK";
		Words[135] = "LARYNX";
		Words[136] = "LENGTHS";
		Words[137] = "LUCKY";
		Words[138] = "LUXURY";
		Words[139] = "LYMPH";
		Words[140] = "MARQUIS";
		Words[141] = "MATRIX";
		Words[142] = "MEGAHERTZ";
		Words[143] = "MICROWAVE";
		Words[144] = "MNEMONIC";
		Words[145] = "MYSTIFY";
		Words[146] = "NAPHTHA";
		Words[147] = "NIGHTCLUB";
		Words[148] = "NOWADAYS";
		Words[149] = "NUMBSKULL";
		Words[150] = "NYMPH";
		Words[151] = "ONYX";
		Words[152] = "OXIDIZE";
		Words[153] = "OXYGEN";
		Words[154] = "PAJAMA";
		Words[155] = "PEEKABOO";
		Words[156] = "PIXEL";
		Words[157] = "PIZAZZ";	
		Words[158] = "PNEUMONIA";
		Words[159] = "POLKA";
		Words[160] = "PSYCHE";
		Words[161] = "PUPPY";
		Words[162] = "PUZZLING";
		Words[163] = "QUARTZ";
		Words[164] = "QUEUE";
		Words[165] = "QUIPS";
		Words[166] = "QUIXOTIC";
		Words[167] = "QUIZ";
		Words[168] = "QUIZZES";
		Words[169] = "QUORUM";
		Words[170] = "RAZZMATAZZ";
		Words[171] = "RHUBARB";
		Words[172] = "RHYTHM";
		Words[173] = "RICKSHAW";
		Words[174] = "SCHNAPPS";
		Words[175] = "SCRATCH";
		Words[176] = "SHIV";
		Words[177] = "SNAZZY";
		Words[178] = "SPHINX";
		Words[179] = "SPRITZ";
		Words[180] = "SQUAWK";
		Words[181] = "STAFF";
		Words[182] = "STRENGTH";
		Words[183] = "STRENGTHS";
		Words[184] = "STRETCH";
		Words[185] = "STRONGHOLD";
		Words[186] = "STYMIED";
		Words[187] = "SUBWAY";
		Words[188] = "SWIVEL";
		Words[189] = "SYNDROME";
		Words[190] = "THRIFTLESS";
		Words[191] = "THUMBSCREW";
		Words[192] = "TOPAZ";
		Words[193] = "TRANSCRIPT";
		Words[194] = "TRANSGRESS";
		Words[195] = "TRANSPLANT";
		Words[196] = "TRIPHTHONG";
		Words[197] = "TWELFTH";
		Words[198] = "TWELFTHS";
		Words[199] = "UNKNOWN";
		Words[200] = "UNWORTHY";
		Words[201] = "UNZIP";
		Words[202] = "UPTOWN";
		Words[203] = "VAPORIZE";
		Words[204] = "VIXEN";
		Words[205] = "VODKA";
		Words[206] = "VOODOO";
		Words[207] = "VORTEX";
		Words[208] = "VOYEURISM";
		Words[209] = "WALKWAY";
		Words[210] = "WALTZ";
		Words[211] = "WAVE";
		Words[212] = "WAVY";
		Words[213] = "WAXY";
		Words[214] = "WELLSPRING";
		Words[215] = "WHEEZY";
		Words[216] = "WHISKEY";
		Words[217] = "WHIZZING";
		Words[218] = "WHOMEVER";
		Words[219] = "WIMPY";
		Words[220] = "WITCHCRAFT";
		Words[221] = "WIZARD";
		Words[222] = "WOOZY";
		Words[223] = "WRISTWATCH";
		Words[224] = "WYVERN";
		Words[225] = "XYLOPHONE";
		Words[226] = "YACHTSMAN";
		Words[227] = "YIPPEE";
		Words[228] = "YOKED";
		Words[229] = "YOUTHFUL";
		Words[230] = "YUMMY";
		Words[231] = "ZEPHYR";
		Words[232] = "ZIGZAG";
		Words[233] = "ZIGZAGGING";
		Words[234] = "ZILCH";
		Words[235] = "ZIPPER";
		Words[236] = "ZODIAC";
		Words[237] = "ZOMBIE";

		int Choice = DungeonGame.RNDM(0, Length);
		char[] Word = Words[Choice].ToCharArray();
		bool[] Guesses = new bool[Word.Length];
		
		string Answer;
		int Points = 0;
		
		for (int H = 0; H == 0; H += 0) {
			
			string Line = "";
			
			for (int L = 0; L < Word.Length; L++) {
				
				if (Guesses[L]) {
					
					Line += Word[L];
					
				} else {
					
					Line += "_";
					
				}
				
				Line += " ";
				
			}
			
			Console.WriteLine(Line + "\nGuess a letter");
			Answer = Console.ReadLine();
			int Right = 0;
			
			for (int A = 0; A < Word.Length; A++) {
				
				if (Answer.ToUpper() == Word[A].ToString()) {
					
					Guesses[A] = true;
					Right = 1;
					
				}
				
			}
			
			if (Right == 0) {
				
				Console.WriteLine("Not right");
				Points++;
				
			} else {
				
				Console.WriteLine("Good Job");
				
			}
			
			Console.WriteLine("");
			
			for (int G = 0; G < Guesses.Length; G++) {
					
				if (!Guesses[G]) {
					
					break;
					
				} else if (G == Guesses.Length - 1) {
					
					Console.WriteLine(Words[Choice]);
					Console.WriteLine("You won with " + Points + " points (points are bad)");
					H++;
					
				}
				
			}
			
		}
		
		Console.ReadLine();
		Console.WriteLine("");
		
	}
	
	public static Stats Heal (Stats stats) {
		
		stats.Health = stats.MaxHealth;
		stats.Stamina = stats.MaxStamina;
		stats.Magic = stats.MaxMagic;
		return stats;
		
	}
	
}