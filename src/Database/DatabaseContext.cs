namespace FusionTech.src.Database
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<StoreEmployee> StoreEmployees { get; set; }
        public DbSet<SystemAdmin> SystemAdmins { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderedGames> OrderedGames { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<Store> Store { get; set; }
        public DbSet<Inventory> Inventory { get; set; }
        public DbSet<Supplier> Supplier { get; set; }
        public DbSet<Supply> Supply { get; set; }
        public DbSet<PersonIdCounter> PersonIdCounters { get; set; }
        public DbSet<GameConsole> Console { get; set; }
        public DbSet<GameStudio> Studio { get; set; }
        public DbSet<Publisher> Publisher { get; set; }
        public DbSet<VideoGameVersion> VideoGameVersion { get; set; }
        public DbSet<VideoGameInfo> VideoGameInfo { get; set; }

        public DatabaseContext(DbContextOptions options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().UseTptMappingStrategy();
            modelBuilder.HasPostgresEnum<PersonType>();

            base.OnModelCreating(modelBuilder);

            // Seed Super Admin
            // this is an extremly sensitive information, it should be removed in a real world scenario.
            PasswordUtils.HashPassword("SuperAdmin", out string hashedPassword, out byte[] salt);

            var SystemAdmin1 = new SystemAdmin
            {
                PersonId = -1,
                PersonEmail = "admin@mail.com",
                PersonName = "Super Admin",
                PersonPassword = hashedPassword,
                PersonPhoneNumber = "+966500000000",
                salt = salt,
                ManageGames = true,
                ManageCustomers = true,
                ManageEmployees = true,
                ManageStores = true,
                ManageSystemAdmins = true,
            };

            // Seed Category data
            var Category1 = new Category
            {
                CategoryId = Guid.Parse("2e32f726-203b-4fa3-a960-3a2c1a275864"),
                CategoryName = "Action",
            };
            var Category2 = new Category
            {
                CategoryId = Guid.Parse("4867a76e-ccc5-4470-a25a-dd1e91cbc87d"),
                CategoryName = "Adventure",
            };
            var Category3 = new Category
            {
                CategoryId = Guid.Parse("0b387646-e3f1-4892-857c-b260a7113ca4"),
                CategoryName = "Racing",
            };

            // Seed GameConsole data
            var Console1 = new GameConsole
            {
                GameConsoleId = Guid.Parse("0268a1b4-571e-4962-90be-471f315c0497"),
                ConsoleName = "GamerBox",
            };
            var Console2 = new GameConsole
            {
                GameConsoleId = Guid.Parse("36be9397-03a5-4dff-a2f2-1f7061faff98"),
                ConsoleName = "FusionPlay",
            };
            var Console3 = new GameConsole
            {
                GameConsoleId = Guid.Parse("41c5f56f-7ebe-4f73-8298-04b3171e56a0"),
                ConsoleName = "RetroCube",
            };
            var Console4 = new GameConsole
            {
                GameConsoleId = Guid.NewGuid(),
                ConsoleName = "PC",
            };
            var Console5 = new GameConsole
            {
                GameConsoleId = Guid.NewGuid(),
                ConsoleName = "Playstation",
            };

            // Seed GameStudio data
            var Studio1 = new GameStudio
            {
                GameStudioId = Guid.NewGuid(),
                StudioName = "FromSoftware",
                StudioPicturePath = "pic1/png",
            };
            var Studio2 = new GameStudio
            {
                GameStudioId = Guid.NewGuid(),
                StudioName = "Treyarch",
                StudioPicturePath = "pic2/png",
            };
            var Studio3 = new GameStudio
            {
                GameStudioId = Guid.NewGuid(),
                StudioName = "Valve",
                StudioPicturePath = "pic3/png",
            };

            var Publisher1 = new Publisher
            {
                PublisherId = Guid.Parse("12ba59b8-6c30-4864-9d48-0f95bd278b40"),
                PublisherName = "Square Enix",
                PublisherEmail = "creators@us.square-enix.com",
                PublisherPicturePath = "https://www.square-enix-games.com/home/public/selogo_onwhite.jpg",
            };
            var Publisher2 = new Publisher
            {
                PublisherId = Guid.Parse("f5ea9a66-8a49-4f1f-ae5d-09ce38a7c80d"),
                PublisherName = "Telltale Games",
                PublisherEmail = " support@telltalegames.com",
                PublisherPicturePath = "https://logowik.com/content/uploads/images/telltale-games5562.jpg",
            };
            var Publisher3 = new Publisher
            {
                PublisherId = Guid.NewGuid(),
                PublisherName = "Codemasters",
                PublisherEmail = " help@codemasters.com",
                PublisherPicturePath = "https://upload.wikimedia.org/wikipedia/en/3/36/Codemasters_logo.svg",
            };

            var VideoGameInfo1 = new VideoGameInfo
            {
                VideoGameInfoId = Guid.Parse("7248c5a6-49e0-4f88-be50-8d87a54c938f"),
                GameName = "Life is Strange: Double Exposure",
                Description = "Max Caulfield, photographer-in-residence at the prestigious Caledon University, discovers her closest new friend, Safi, dead in the snow. Murdered. To save her, Max tries to Rewind time - a power she’s not used in years... instead, Max opens the way to a parallel timeline where Safi is still alive, and still in danger! Max realizes the killer will soon strike again - in both versions of reality. With her new power to Shift between two timelines - can Max solve and prevent the same murder?",
                YearOfRelease = "Oct 29, 2024",
                TotalRating = 3,
                PublisherId = Publisher1.PublisherId,
                GamePicturePath = "https://media.rawg.io/media/resize/640/-/games/279/279a4377b3499615155908764e297e1c.jpg",
            };
            var VideoGameInfo2 = new VideoGameInfo
            {
                VideoGameInfoId = Guid.Parse("ee4836d4-d131-47fe-b741-3c104f14df71"),
                GameName = "The Wolf Among Us ",
                Description = "The Wolf Among Us is a five-part episodic game relying heavily on dialogues and choices of the player. The game is considered a prequel to Bill Willingham's 'Fables' comic book and features usual TellTale stylistics: cartoon-like graphics, comparing your choices to the decisions of the other players and QTEs. 'The Wolf' is the first part of the series with a promised expansion to the second season coming out in 2019.You play as Bigby Wolf; he is a Sheriff of a Fabletown: as a typical Sheriff, you need to fulfill the requests of the Fabletown's residents and uncover mysteries lying behind the crimes there. The gameplay consists of choosing the dialogue options, reacting to QTE button-mash and watching cutscenes.",
                YearOfRelease = "Oct 10, 2013",
                TotalRating = 5,
                PublisherId = Publisher2.PublisherId,
                GamePicturePath = "https://media.rawg.io/media/resize/640/-/games/845/84539f8f33fea2c753cca0ce3a6d168f.jpg",
            };
            var VideoGameInfo3 = new VideoGameInfo
            {
                VideoGameInfoId = Guid.NewGuid(),
                GameName = "Rise of the Tomb Raider",
                Description = "Rise of the Tomb Raider is the eleventh entry in the franchise, being a sequel to its predecessor, Tomb Raider, a reboot of the franchise. This story follows Lara Croft, one year after battling her supernatural experiences in Yamatai. This time she is trying to find the legendary city of Kitezh in Siberia, Russia. The legend behind the city begins in the 12th century and still comes nowadays, that this ancient city grants with a promise of immortality. While Lara tries to solve the mystery of Siberia, she encounters an organisation called Trinity. They want to retrieve this gift to themselves. Following the notes of her father, Lara tries to discover the secrets of the ancient city and stop Trinity in doing so.Exploring the Soviet motive,even more,the game has the DLC's - Baba Yaga, the Temple of the Witch, which follows Lara in the Soviet mine and confronting the legendary witch of Russian folk-tales, Cold Darkness Awakened, the story about a secret biological weapon and Blood Ties and Lara's Nightmare - a fight for ownership of the Croft estate.",
                YearOfRelease = "Nov 10, 2015",
                TotalRating = 5,
                PublisherId = Publisher1.PublisherId,
                GamePicturePath = "https://media.rawg.io/media/resize/640/-/games/845/84539f8f33fea2c753cca0ce3a6d168f.jpg",
            };
            var VideoGameInfo4 = new VideoGameInfo
            {
                VideoGameInfoId = Guid.NewGuid(),
                GameName = "GRID (2008)",
                Description = "GRID is a racing game that lets the player dive into the motorsport, assume the real racer’s role and even control their own racing team. Races and racing championships are held in three main locations – the United States, Europe, and Japan. All racing circuits in the game are the mixture of imaginary and the existing ones. The gameplay is divided into 6 racing classes: GT championships, drifting, touge (climbing the narrow mountain pass like Pikes Peak), open wheel racing, demolition derby, and 24 Hours of Le Mans (additional at the end of the season). Each car of 43 available in the game is tied to one of the event types. Several professional teams compete within these championships. Therefore, to start the career player have to choose one of the disciplines and a professional team to join. While progressing GRID gives an opportunity to create your own racing team, hire sponsors and other drivers, and participate in different events. The gameplay also has a remarkable feature called “flashback” that allows rewinding time to prevent driver’s mistakes.",
                YearOfRelease = "Jun 3, 2008",
                TotalRating = 5,
                PublisherId = Publisher3.PublisherId,
                GamePicturePath = "https://media.rawg.io/media/resize/640/-/games/845/84539f8f33fea2c753cca0ce3a6d168f.jpg",
            };
            var VideoGameInfo5 = new VideoGameInfo
            {
                VideoGameInfoId = Guid.NewGuid(),
                GameName = "Operation Flashpoint: Red River",
                Description = "Operation Flashpoint: Red River is a tactical first-person shooter, set in the modern world. The game is a sequel to Operation Flashpoint: Dragon Rising, and overall a third game in the series.The game’s protagonists are a squad of four US Marine Corps soldiers,each with their unique skills and fighting capabilities.The main campaign focuses on a fictional conflict in the Middle East,featuring both single - player mode and cooperative multiplayer.The battles in Operation Flashpoint are unique in a way that the players will feel the battleground,facing a real threat of getting their platoon killed,therefore making them plan their every step and use the surroundings to ensure victory.While,the game lacks competitive multiplayer,due to its focus on realism and refined experience of a fast - paced military simulator,the cooperative experience will allow players to fully immerse themselves in what would seem like a real test of nerves,teamwork,and tactics.",
                YearOfRelease = "Apr 19, 2011",
                TotalRating = 5,
                PublisherId = Publisher3.PublisherId,
                GamePicturePath = "https://media.rawg.io/media/resize/640/-/games/810/8100f945426cd77450ae0c62cffcb288.jpg",
            };
            var VideoGameInfo6 = new VideoGameInfo
            {
                VideoGameInfoId = Guid.NewGuid(),
                GameName = "Just Cause 2",
                Description = "Just Cause II follows a story of Rico Rodriguez, who arrives yet on another fictional island. Previously being on the Caribbean, now he is coming to Panau - an island in Southeast Asia. This time, Rico has to overthrow the dictatorial regime with its leader, Pandak 'Baby' Panay and confront his former mentor, Tom Sheldon. When Rico arrives at the island, he discovers three criminal gangs: The Roaches, The Reapers and the Ular Boys. In order to prevail, Rico has to fight all of the three fractions as well.One of the key features of the game is speed.This game is filled with adrenaline and ways of doing things very fastly.A wide variety of vehicles such as planes,boats,cars and other.A grappling hook is also available for the player as he can make his character fly around like Spider - Man or tie enemies to each other.There is a big choice of weaponry as well - you can have a pistol, two pistols, auto - rifles or even a grenade launcher! Having an open world map provides a player with experience do whatever they please - flying around, making missions or just discovering new things on the island.",
                YearOfRelease = "Mar 23, 2010",
                TotalRating = 5,
                PublisherId = Publisher1.PublisherId,
                GamePicturePath = "https://upload.wikimedia.org/wikipedia/en/thumb/3/3b/Just_Cause_2.jpg/220px-Just_Cause_2.jpg",
            };
            var VideoGameInfo7 = new VideoGameInfo
            {
                VideoGameInfoId = Guid.NewGuid(),
                GameName = "Hitman: Absolution",
                Description = "The direct sequel to the Hitman: Blood money, Absolution tells the story of Agent 47, the true intentions of his Agency and how top Agent became a renegade on the run. Unlike previous games in the series, players will get more linear and cinematic experience. The game revolves around objective-based missions, providing various methods of completion. Players can avoid direct confrontation by disguising themselves in other people’s uniforms and use environmental interactions to distract or kill unsuspecting targets. And in case of raising the alarm, players can try to rush the mission with the direct attack, using dozens of available weapons.Players can use special vision mechanic,called Instinct.It allows seeing through the solid surfaces in order to observe NPC’s,items that can be interacted with and predict the movement of patrolling guards.Absolution provides players with additional challenges and collectibles in order to invite players to explore the maps.",
                YearOfRelease = "Nov 19, 2012",
                TotalRating = 5,
                PublisherId = Publisher1.PublisherId,
                GamePicturePath = "https://cms.ioi.dk/media/2rpp2awd/hitman_absolution.jpg?width=2560",
            };
            var VideoGameInfo8 = new VideoGameInfo
            {
                VideoGameInfoId = Guid.NewGuid(),
                GameName = "The Walking Dead: Michonne",
                Description = "The Walking Dead: Michonne - A Telltale Miniseries stars the iconic, blade-wielding character from Robert Kirkman's best-selling comic books. Haunted by her past, and coping with unimaginable loss and regret, the story explores Michonne's absence between issues #126 and #139 of the comic book. In this three part miniseries, players will discover what took Michonne away from Rick, Ezekiel, and the rest of her trusted group… and what brought her back.",
                YearOfRelease = "Feb 22, 2016",
                TotalRating = 5,
                PublisherId = Publisher2.PublisherId,
                GamePicturePath = "https://media.rawg.io/media/resize/640/-/games/b30/b30d472a13528007721f4a236b04ae7f.jpg",
            };
            var VideoGameInfo9 = new VideoGameInfo
            {
                VideoGameInfoId = Guid.NewGuid(),
                GameName = "Poker Night 2",
                Description = "Playing poker is good in itself and as an occasion for live communication, a disclosure of communicative talents, a great way to spend time with friends. Especially if these friends know how to play and have fun playing.This poker simulator allows you to spend time in a beautiful company.The game lets you play with Sam(Sam & Max franchise),assisted by Max,Brock Samson(The Venture Bros.),Ash Williams(The Evil Dead) and Claptrap(Borderlands).The dealer of the game is GLaDOS(Portal series). Some other popular characters take part as additional characters or cameos.All players start the game with the same amount of in-game money,the goal is to win the money of other players.The game can be played in Texas hold 'em style or in Omaha hold' em.",
                YearOfRelease = "Apr 24, 2013",
                TotalRating = 5,
                PublisherId = Publisher2.PublisherId,
                GamePicturePath = "https://media.rawg.io/media/resize/640/-/screenshots/e40/e40b8c0637de401eb1dec5f5eb05ad33.jpg",
            };
            var VideoGameInfo10 = new VideoGameInfo
            {
                VideoGameInfoId = Guid.NewGuid(),
                GameName = "Back to the Future: The Game",
                Description = "Marty McFly and Doc Brown return in a completely new Back to the Future adventure. Six months after the events of the third film, the DeLorean Time Machine mysteriously returns to Hill Valley - driverless! Marty must go back in time and get aid from a resistant teenage Emmett Brown, or else the space time continuum will forever be unraveled!",
                YearOfRelease = "Dec 21, 2010",
                TotalRating = 5,
                PublisherId = Publisher2.PublisherId,
                GamePicturePath = "https://media.rawg.io/media/resize/640/-/games/e2e/e2eac90903c56886e39d21ac71b958e5.jpg",
            };
            var VideoGameInfo11 = new VideoGameInfo
            {
                VideoGameInfoId = Guid.NewGuid(),
                GameName = "Jurassic Park: The Game",
                Description = "Security systems have failed and the creatures of the park roam free. Now, a rogue corporation will stop at nothing to acquire the dinosaur embryos stolen and lost by Dennis Nedry. Experience a brand new adventure set during the events of the first Jurassic Park movie and see new areas and dinosaurs in this landmark adventure 65 million years in the making!",
                YearOfRelease = "Nov 15, 2011",
                TotalRating = 5,
                PublisherId = Publisher2.PublisherId,
                GamePicturePath = "https://media.rawg.io/media/resize/640/-/screenshots/5f7/5f72fb91f10f4a1c24fe1861877701c5.jpg",
            };
            var VideoGameInfo12 = new VideoGameInfo
            {
                VideoGameInfoId = Guid.NewGuid(),
                GameName = "F1 2015",
                Description = "F1 2015 is a racing simulator based on the 2015 Formula One season, but with teams from the 2014 season (including the Hockenheimring track, which is missed from the 2015 season calendar). Seventh in the series. It presents the crews and pilots who participated directly in this season. Unlike its predecessors, the game received a new engine, improved physics and graphics.A 'Pro Season' mode was featured.This mode was different from the usual championship in a complete lack of interface and management assistance, as well as the highest level of complexity.The career mode, which was in the previous parts of the series, did not appear in the game.",
                YearOfRelease = "Jul 9, 2015",
                TotalRating = 5,
                PublisherId = Publisher3.PublisherId,
                GamePicturePath = "https://media.rawg.io/media/resize/640/-/games/ff6/ff66ce127716df74175961831ad3a23a.jpg",
            };
            var VideoGameInfo13 = new VideoGameInfo
            {
                VideoGameInfoId = Guid.NewGuid(),
                GameName = "Overlord: Raising Hell",
                Description = "How evil can you get? Discover how corruptible you are in Overlord, the twisted fantasy action adventure where you can be evil(or really evil).In the game's seriously warped fantasy world, players will become the Overlord and get first-hand experience of how absolute power corrupts absolutely. You could be a regular run-of-the-mill Overlord. However, with incredible power at your disposal and a team of evil-minded impish critters, the Minions, on hand to do your bidding, how will you resist the temptation to be wonderfully despotic?!Go deeper into the Overlord's twisted world as the single-player expansion content opens a series of hellish new levels, each a supernatural abyss for the game's five kingdoms: Mellow Hills, Evernight, Heaven's Peak, the Golden Halls and the Ruborian Desert. Access to each abyss is via a portal, which opens once a kingdom has been successfully conquered and the previous ruler banished to a personal hell within. However it's not just the fallen heroes that have been dragged into the abyss: the Overlord's newly loyal peasants have also been taken down into hell too.",
                YearOfRelease = "Feb 15, 2008",
                TotalRating = 5,
                PublisherId = Publisher3.PublisherId,
                GamePicturePath = "https://media.rawg.io/media/resize/640/-/games/f8c/f8c181db845de856e519558451b8e481.jpg",
            }; 
            var VideoGameInfo14 = new VideoGameInfo
            {
                VideoGameInfoId = Guid.NewGuid(),
                GameName = "Law & Order: Legacies",
                Description = "Law & Order: Legacies is an adventure game developed by Telltale Games. It was originally released in 2012. It was published by Telltale Games. The game is rated as 'Recommended' on RAWG. Law & Order: Legacies is available on PC. Dave Felton and Jason Lars Berquist produced the game. It was scored by Jared Emerson-Johnson and Mike Post.",
                YearOfRelease = "Jan 30, 2012",
                TotalRating = 5,
                PublisherId = Publisher2.PublisherId,
                GamePicturePath = "https://media.rawg.io/media/resize/640/-/games/924/9240437114ad379c874170a3feb84225.jpg",
            };
            var VideoGameInfo15 = new VideoGameInfo
            {
                VideoGameInfoId = Guid.NewGuid(),
                GameName = "The Walking Dead: Michonne - Episode 2: Give No Shelter",
                Description = "The Walking Dead: Michonne - Episode 2: Give No Shelter is an adventure game developed by Skybound. It came out on 29-03-2016. It was published by Telltale Games. Most rawgers rated the game as 'Recommended'. The Walking Dead: Michonne - Episode 2: Give No Shelter is available on PC and PlayStation 3.",
                YearOfRelease = "Mar 29, 2016",
                TotalRating = 5,
                PublisherId = Publisher2.PublisherId,
                GamePicturePath = "https://media.rawg.io/media/resize/640/-/screenshots/b35/b3591ebcb7b870e9f8a90ab6c6428650.jpg",
            };
            var VideoGameInfo16 = new VideoGameInfo
            {
                VideoGameInfoId = Guid.NewGuid(),
                GameName = "Hitman",
                Description = "Hitman is a six episodes game with different contracts. The action takes place as a prequel to Hitman: Agent 47 (only prologue) and episodes take place six years after Hitman: Absolution. All contracts are being ordered by a 'shadow client' and seem to be unrelated. But as you fulfil those contracts, you start to realise that all of the targets somehow are a part of a secret organisation called the Providence.",
                YearOfRelease = "Mar 11, 2016",
                TotalRating = 5,
                PublisherId = Publisher1.PublisherId,
                GamePicturePath = "https://upload.wikimedia.org/wikipedia/en/8/84/Hitman_2015.jpg",
            };
            var VideoGameInfo17= new VideoGameInfo
            {
                VideoGameInfoId = Guid.NewGuid(),
                GameName = "Just Cause 3",
                Description = "Just Cause 3 is an open-world action adventure with the large locus on freedom of exploring. It is the thirds title in the Just Cause series produced by Avalanche Studios, preceded by the first two numerical parts and having the 4th part not yet released as its successor.Rico Rodriguez is the protagonist of the game, who is continually being forced to deal with bandits and dictators somewhere in the Mediterranean.The events of the third game in the series take place 6 years after the second installment.",
                YearOfRelease = "Nov 30, 2015",
                TotalRating = 5,
                PublisherId = Publisher1.PublisherId,
                GamePicturePath = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSXOotQAZ915ldrPeqtjU_ZBv_kc2r7u5mVIqezWZLjaPg2Icy0QOCQxvRo_DGVigfZHYK_Ow",
            };
            var VideoGameInfo18 = new VideoGameInfo
            {
                VideoGameInfoId = Guid.NewGuid(),
                GameName = "Rise of the Argonauts",
                Description = "The role model: Released in 2008, the game, is similar to another well - known representative of the genre of action - role - playing games God of War series.Developers became studio Liquid Entertainment, and the publisher company Codemasters.The game appeared on the PC and on the most popular consoles of its generation: Playstation 3 and Xbox 360. The story and the setting: The plot of the game tells about Jason, and the action takes place in Ancient Greece. Like God of War, the game uses ancient Greek mythology to build a game universe. The modified myth of Jason and the Argonauts, who went on a journey for the Golden Fleece was used as inspiration.According to the scriptwriters of the game, Jason is a Greek king, whose wife was killed in front of him.The only way for a grieving husband to return the beloved is the Golden Fleece, which can resurrect the dead.Other well-known heroes of myths appear in the game: Hercules, Achilles, Medea, Medusa, Patroclus, and others. Together they travel through a variety of real and imaginary locations: Iolcu, Delphi, Mycenae, Tartar, and Kifr.",
                YearOfRelease = "Dec 12, 2008",
                TotalRating = 5,
                PublisherId = Publisher3.PublisherId,
                GamePicturePath = "https://media.rawg.io/media/resize/640/-/games/760/760b379c7d3ab6eb68375fba0f81aa96.jpg",
            };
            var VideoGameInfo19 = new VideoGameInfo
            {
                VideoGameInfoId = Guid.NewGuid(),
                GameName = "Damnation",
                Description = "Evolving the shooter genre with its unique and exhilarating combination of fluid action and combat, Damnation features huge, open environments, frenetic combat, daredevil acrobatics and high-octane vehicle-based stunts. Presenting players with an intense test of reflexes, quick thinking and rapid-fire conflict, Damnation will feature vast, breathtaking landscapes, each covering miles of distance and thousands of vertical feet. Billed as a shooter gone vertical and visually inspired by iconic elements of American history, these massive streaming landscapes will form the battlegrounds for a post-industrial conflict between humanity and an unstoppable arms dealer hell - bent on total world domination.",
                YearOfRelease = "May 22, 2009",
                TotalRating = 5,
                PublisherId = Publisher3.PublisherId,
                GamePicturePath = "https://media.rawg.io/media/resize/640/-/games/9da/9da54595a8b04299934a1a3780ca0a7f.jpg",
            };
            var VideoGameInfo20 = new VideoGameInfo
            {
                VideoGameInfoId = Guid.NewGuid(),
                GameName = "ToCA Race Driver",
                Description = "Pro Race Driver features 42 licensed touring and racecars, including the Holden Commodore, Ford Falcon, Mercedes CLK, Alfa Romeo GTV, and Viper GTS. Thirty-eight international circuits are re-created under license, including Bathurst, Hockenheimring, and Silverstone. The 13 global championships include DTM from Germany, V8 Supercars from Australia, and the British Touring Car Championship. The state-of-the-art car physics engine was tested for realism by professional race drivers. A customizable car setup provides a uniquely true-to-life driving and performance experience. Real, visible damage is created using the crash test industry's FEM system, and it affects the handling and drivability of vehicles.",
                YearOfRelease = "Apr 1, 2003",
                TotalRating = 5,
                PublisherId = Publisher3.PublisherId,
                GamePicturePath = "https://media.rawg.io/media/resize/640/-/games/842/84228de4491072935b6543588bbe873f.jpg",
            }; 

            var VideoGameVersion1 = new VideoGameVersion
            {
                VideoGameVersionId = Guid.NewGuid(),
                Price = 80,
                VideoGameInfoId = VideoGameInfo1.VideoGameInfoId,
                GameConsoleId = Console1.GameConsoleId,
            };
            var VideoGameVersion2 = new VideoGameVersion
            {
                VideoGameVersionId = Guid.NewGuid(),
                Price = 85,
                VideoGameInfoId = VideoGameInfo2.VideoGameInfoId,
                GameConsoleId = Console2.GameConsoleId,
            };
            var VideoGameVersion3 = new VideoGameVersion
            {
                VideoGameVersionId = Guid.NewGuid(),
                Price = 90,
                VideoGameInfoId = VideoGameInfo3.VideoGameInfoId,
                GameConsoleId = Console2.GameConsoleId,
            };
            var VideoGameVersion4 = new VideoGameVersion
            {
                VideoGameVersionId = Guid.NewGuid(),
                Price = 75,
                VideoGameInfoId = VideoGameInfo4.VideoGameInfoId,
                GameConsoleId = Console2.GameConsoleId,
            };
            var VideoGameVersion5 = new VideoGameVersion
            {
                VideoGameVersionId = Guid.NewGuid(),
                Price = 85,
                VideoGameInfoId = VideoGameInfo5.VideoGameInfoId,
                GameConsoleId = Console2.GameConsoleId,
            };
            var VideoGameVersion6 = new VideoGameVersion
            {
                VideoGameVersionId = Guid.NewGuid(),
                Price = 95,
                VideoGameInfoId = VideoGameInfo6.VideoGameInfoId,
                GameConsoleId = Console2.GameConsoleId,
            };
            var VideoGameVersion7 = new VideoGameVersion
            {
                VideoGameVersionId = Guid.NewGuid(),
                Price = 84,
                VideoGameInfoId = VideoGameInfo7.VideoGameInfoId,
                GameConsoleId = Console2.GameConsoleId,
            };
            var VideoGameVersion8 = new VideoGameVersion
            {
                VideoGameVersionId = Guid.NewGuid(),
                Price = 70,
                VideoGameInfoId = VideoGameInfo8.VideoGameInfoId,
                GameConsoleId = Console2.GameConsoleId,
            };
            var VideoGameVersion9 = new VideoGameVersion
            {
                VideoGameVersionId = Guid.NewGuid(),
                Price = 65,
                VideoGameInfoId = VideoGameInfo9.VideoGameInfoId,
                GameConsoleId = Console2.GameConsoleId,
            };
            var VideoGameVersion10 = new VideoGameVersion
            {
                VideoGameVersionId = Guid.NewGuid(),
                Price = 100,
                VideoGameInfoId = VideoGameInfo10.VideoGameInfoId,
                GameConsoleId = Console2.GameConsoleId,
            };
            var VideoGameVersion11 = new VideoGameVersion
            {
                VideoGameVersionId = Guid.NewGuid(),
                Price = 73,
                VideoGameInfoId = VideoGameInfo11.VideoGameInfoId,
                GameConsoleId = Console2.GameConsoleId,
            };
            var VideoGameVersion12 = new VideoGameVersion
            {
                VideoGameVersionId = Guid.NewGuid(),
                Price = 109,
                VideoGameInfoId = VideoGameInfo12.VideoGameInfoId,
                GameConsoleId = Console2.GameConsoleId,
            };
            var VideoGameVersion13 = new VideoGameVersion
            {
                VideoGameVersionId = Guid.NewGuid(),
                Price = 110,
                VideoGameInfoId = VideoGameInfo13.VideoGameInfoId,
                GameConsoleId = Console2.GameConsoleId,
            };
            var VideoGameVersion14 = new VideoGameVersion
            {
                VideoGameVersionId = Guid.NewGuid(),
                Price = 120,
                VideoGameInfoId = VideoGameInfo14.VideoGameInfoId,
                GameConsoleId = Console4.GameConsoleId,
            };
            var VideoGameVersion15 = new VideoGameVersion
            {
                VideoGameVersionId = Guid.NewGuid(),
                Price = 125,
                VideoGameInfoId = VideoGameInfo15.VideoGameInfoId,
                GameConsoleId = Console5.GameConsoleId,
            };
            var VideoGameVersion16 = new VideoGameVersion
            {
                VideoGameVersionId = Guid.NewGuid(),
                Price = 100,
                VideoGameInfoId = VideoGameInfo16.VideoGameInfoId,
                GameConsoleId = Console5.GameConsoleId,
            };
            var VideoGameVersion17 = new VideoGameVersion
            {
                VideoGameVersionId = Guid.NewGuid(),
                Price = 125,
                VideoGameInfoId = VideoGameInfo17.VideoGameInfoId,
                GameConsoleId = Console5.GameConsoleId,
            };
            var VideoGameVersion18 = new VideoGameVersion
            {
                VideoGameVersionId = Guid.NewGuid(),
                Price = 125,
                VideoGameInfoId = VideoGameInfo18.VideoGameInfoId,
                GameConsoleId = Console5.GameConsoleId,
            };
            var VideoGameVersion19 = new VideoGameVersion
            {
                VideoGameVersionId = Guid.NewGuid(),
                Price = 125,
                VideoGameInfoId = VideoGameInfo19.VideoGameInfoId,
                GameConsoleId = Console5.GameConsoleId,
            };
            var VideoGameVersion20 = new VideoGameVersion
            {
                VideoGameVersionId = Guid.NewGuid(),
                Price = 125,
                VideoGameInfoId = VideoGameInfo20.VideoGameInfoId,
                GameConsoleId = Console4.GameConsoleId,
            };



            var Store1 = new Store
            {
                StoreId = Guid.NewGuid(),
                WorkHours = 35,
                Location = "Riyadh",
            };
            var Store2 = new Store
            {
                StoreId = Guid.NewGuid(),
                WorkHours = 40,
                Location = "Jeddah",
            };

            PasswordUtils.HashPassword(
                "StoreEmployee",
                out string hashedPassword2,
                out byte[] salt2
            );

            var storeEmployee1 = new StoreEmployee
            {
                PersonId = 1000,
                PersonEmail = "employee@mail.com",
                PersonName = "Store Employee",
                PersonPassword = hashedPassword2,
                PersonPhoneNumber = "+966500000005",
                salt = salt2,
                Role = "StoreEmployee",
                Salary = 4827f,
                YearsOfService = 5,
                StoreId = Store1.StoreId,
            };

            var Inventory1 = new Inventory
            {
                InventoryId = Guid.NewGuid(),
                VideoGameVersionId = VideoGameVersion1.VideoGameVersionId,
                StoreId = Store1.StoreId,
                GameQuantity = 250,
            };
            var Inventory2 = new Inventory
            {
                InventoryId = Guid.NewGuid(),
                VideoGameVersionId = VideoGameVersion2.VideoGameVersionId,
                StoreId = Store2.StoreId,
                GameQuantity = 400,
            };

            // Seed Payment data
            var Payment1 = new Payment
            {
                PaymentId = Guid.NewGuid(),
                PaymentMethod = "Cash on delivery",
            };
            var Payment2 = new Payment { PaymentId = Guid.NewGuid(), PaymentMethod = "Visa" };
            var Payment3 = new Payment { PaymentId = Guid.NewGuid(), PaymentMethod = "Mada" };
            var Payment4 = new Payment { PaymentId = Guid.NewGuid(), PaymentMethod = "Apple Pay" };

            // Seed PersonIdCounter data
            var PersonIdCounter1 = new PersonIdCounter
            {
                PersonIdCounterId = PersonType.SystemAdmin,
                CurrentId = 0,
            };
            var PersonIdCounter2 = new PersonIdCounter
            {
                PersonIdCounterId = PersonType.StoreEmployee,
                CurrentId = 0,
            };
            var PersonIdCounter3 = new PersonIdCounter
            {
                PersonIdCounterId = PersonType.Customer,
                CurrentId = 0,
            };

            // Seed Supplier data
            var Supplier1 = new Supplier
            {
                SupplierId = Guid.NewGuid(),
                SupplierName = "Tech Supplies Co",
                SupplierContactInfo = "contact@techsupplies.com, +966-800-555-0199",
                SupplierBankInfo = "Account No: 123456789",
            };
            var Supplier2 = new Supplier
            {
                SupplierId = Guid.NewGuid(),
                SupplierName = "Gaming Goods Ltd",
                SupplierContactInfo = "support@gaminggoods.com, +966-800-555-0198",
                SupplierBankInfo = "Account No: 987654321",
            };

            var Supply1 = new Supply
            {
                SupplyId = Guid.NewGuid(),
                SupplierId = Supplier1.SupplierId,
                VideoGameVersionId = VideoGameVersion1.VideoGameVersionId,
                SupplyQuantity = 100,
                SupplierDate = DateTime.UtcNow,
                InventoryId = Inventory1.InventoryId,
            };
            var Supply2 = new Supply
            {
                SupplyId = Guid.NewGuid(),
                SupplierId = Supplier2.SupplierId,
                VideoGameVersionId = VideoGameVersion2.VideoGameVersionId,
                SupplyQuantity = 50,
                SupplierDate = DateTime.UtcNow.AddDays(-1),
                InventoryId = Inventory2.InventoryId,
            };

            // Seed Publisher data










            // Seed Inventory data


            // Seed Supply data

            // modelBuilder
            modelBuilder.Entity<SystemAdmin>().HasData(SystemAdmin1);

            modelBuilder.Entity<Category>().HasData(Category1, Category2, Category3);

            modelBuilder.Entity<GameConsole>().HasData(Console1, Console2, Console3);

            modelBuilder.Entity<GameStudio>().HasData(Studio1, Studio2, Studio3);

            modelBuilder.Entity<Publisher>().HasData(Publisher1, Publisher2, Publisher3);

            modelBuilder.Entity<VideoGameInfo>().HasData(VideoGameInfo1, VideoGameInfo2, VideoGameInfo3, VideoGameInfo4);

            modelBuilder.Entity<VideoGameVersion>().HasData(VideoGameVersion1, VideoGameVersion2);

            modelBuilder.Entity<Store>().HasData(Store1, Store2);
            modelBuilder.Entity<StoreEmployee>().HasData(storeEmployee1);

            modelBuilder.Entity<Inventory>().HasData(Inventory1, Inventory2);

            modelBuilder.Entity<Payment>().HasData(Payment1, Payment2, Payment3, Payment4);

            modelBuilder
                .Entity<PersonIdCounter>()
                .HasData(PersonIdCounter1, PersonIdCounter2, PersonIdCounter3);

            modelBuilder.Entity<Supplier>().HasData(Supplier1, Supplier2);

            modelBuilder.Entity<Supply>().HasData(Supply1, Supply2);

            modelBuilder
                .Entity<Category>()
                .HasMany(c => c.VideoGameInfos)
                .WithMany(v => v.Categories)
                .UsingEntity(j =>
                    j.HasData(
                        new
                        {
                            CategoriesCategoryId = Category1.CategoryId,
                            VideoGameInfosVideoGameInfoId = VideoGameInfo1.VideoGameInfoId,
                        },
                        new
                        {
                            CategoriesCategoryId = Category2.CategoryId,
                            VideoGameInfosVideoGameInfoId = VideoGameInfo1.VideoGameInfoId,
                        },
                        new
                        {
                            CategoriesCategoryId = Category1.CategoryId,
                            VideoGameInfosVideoGameInfoId = VideoGameInfo2.VideoGameInfoId,
                        }
                    )
                );
        }
    }
}
