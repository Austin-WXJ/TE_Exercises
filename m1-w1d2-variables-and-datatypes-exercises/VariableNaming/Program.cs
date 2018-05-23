using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableNaming
{
    class Program
    {
        static void Main(string[] args)
        {
        
            /*
            INSTRUCTIONS

            The primary purposes of these exercises are to practice: 
                    
                    1. declaring variables and using assignment statements
                    2. using variables, literals, and operators within arithmetic expressions
                    3. choosing meaningful variable names
                    4. choosing appropriate data types

            One of the hardest things about programming is choosing good names. Spend time
            to find good, meaningful, and descriptive names for your variables. Clarity and
            expressiveness is more important than brevity. Err on the side of longer, more 
            descriptive names over short, cryptic ones.

            Be consistent with your choice of datatypes, especially when it comes to 
            some values like money. There are many different ways to express money. Pick one, 
            and stick with it throughout these exercises.
            
            Keep your code consistent and well formatted. When code is poorly indented, 
            or lost in a flood of blank lines, it can make code difficult to read. 
            */

            /* 
            1. 4 birds are sitting on a branch. 1 flies away. How many birds are left on
            the branch? 
            */
            
            // ### EXAMPLE:  
            int initialNumberOfBirds = 4;
            int birdsThatFlewAway = 1;
            int remainingNumberOfBirds = initialNumberOfBirds - birdsThatFlewAway;

            /* 
            2. There are 6 birds and 3 nests. How many more birds are there than
            nests? 
            */
            
            // ### EXAMPLE: 
            int numberOfBirds = 6;
            int numberOfNests = 3;
            int numberOfExtraBirds = numberOfBirds - numberOfNests;

            /* 
            3. 3 raccoons are playing in the woods. 2 go home to eat dinner. How
            many raccoons are left in the woods? 
            */
            int raccoonsInwoods = 3;
            int raccoonsGoHome = 2;
            int raccoonsLeftInWoods = raccoonsInwoods - raccoonsGoHome;
            /* 
            4. There are 5 flowers and 3 bees. How many less bees than flowers? 
            */
            int flowers = 5;
            int bees = 3;
            int lessBeesthanFlowers = flowers - bees;

            /* 
            5. 1 lonely pigeon was eating breadcrumbs. Another pigeon came to eat
            breadcrumbs, too. How many pigeons are eating breadcrumbs now? 
            */
            // two variables
            int lonelyPigeon = 1;
            int partyPigeons = ++lonelyPigeon;

            /* 
            6. 3 owls were sitting on the fence. 2 more owls joined them. How many
            owls are on the fence now? 
            */
            int fenceOwls = 3;
            int interloperOwls = 2;
            int totalOwls = fenceOwls + interloperOwls;


            /* 
            7. 2 beavers were working on their home. 1 went for a swim. How many
            beavers are still working on their home? 
            */
            int Beavers = 2;
            int swimmingBeavers = 1;
            int buildingBeavers = Beavers - swimmingBeavers;


            /* 
            8. 2 toucans are sitting on a tree limb. 1 more toucan joins them. How
            many toucans in all? 
            */
            int sittingToucans = 2;
            int interloperToucans = 1;
            int totalToucans = interloperToucans + sittingToucans;


            /* 
            9. There are 4 squirrels in a tree with 2 nuts. How many more squirrels
            are there than nuts? 
            */
            int squirrels = 4;
            int nuts = 2;
            int squirrelsVsNuts = squirrels - nuts;


            /* 
            10. Mrs. Hilt found a quarter, 1 dime, and 2 nickels. How much money did
            she find? 
            */
            double quarters = 0.25;
            double dimes = 0.10;
            double nickels = 0.05;
            int nickelMultiplier = 2;
            double foundMoneyMrsHilt = quarters + dimes + nickels * nickelMultiplier;
            Console.WriteLine(value: "foundMoneyMrsHilt : " + foundMoneyMrsHilt);

            /* 
            11. Mrs. Hilt's favorite first grade classes are baking muffins. Mrs. Brier's
            class bakes 18 muffins, Mrs. MacAdams's class bakes 20 muffins, and
            Mrs. Flannery's class bakes 17 muffins. How many muffins does first
            grade bake in all? 
            */
            int briersMuffins = 18;
            int macAdamsMuffins = 20;
            int flanneryMuffins = 17;
            int totalFirstGradeMuffins = briersMuffins + macAdamsMuffins + flanneryMuffins;

            /*
            12. Mrs. Hilt bought a yoyo for 24 cents and a whistle for 14 cents. How
            much did she spend in all for the two toys?
            */
            double yoyoPrice = 0.24;
            double whistlePrice = 14;
            double costHilt = yoyoPrice + whistlePrice;


            /*
            13. Mrs. Hilt made 5 Rice Krispie Treats. She used 8 large marshmallows
            and 10 mini marshmallows.How many marshmallows did she use
            altogether?
            */
            int miniMarshmallow = 10;
            int largeMarshmallow = 8;
            int totalMarshmallow = miniMarshmallow + largeMarshmallow;


            /*
            14. At Mrs. Hilt's house, there was 29 inches of snow, and Brecknock
            Elementary School received 17 inches of snow. How much more snow
            did Mrs. Hilt's house have?
            */
            int snowHiltHouse = 29;
            int snowBrecknock = 17;
            int snowDifference = snowHiltHouse - snowBrecknock;


            /*
            15. Mrs. Hilt has $10. She spends $3 on a toy truck and $2 on a pencil
            case. How much money does she have left?
            */
            int cashHilt = 10;
            int toyTruckCost = 3;
            int pencilCaseCost = 2;
            int cashHiltRemaining = cashHilt - toyTruckCost - pencilCaseCost;


            /*
            16. Josh had 16 marbles in his collection. He lost 7 marbles. How many
            marbles does he have now?
            */
            int joshMarbleCollection = 16;
            int marblesLost = 7;
            int joshMarblesRemain = joshMarbleCollection - marblesLost;


            /*
            17. Megan has 19 seashells. How many more seashells does she need to
            find to have 25 seashells in her collection?
            */
            int shellsNeeded = 25;
            int shellsMeganHas = 19;
            int shellsMeganNeeds = shellsNeeded - shellsMeganHas;


            /*
            18. Brad has 17 balloons. 8 balloons are red and the rest are green. How
            many green balloons does Brad have?
            */
            int bradBalloons = 17;
            int redBalloons = 8;
            int greenBalloons = bradBalloons + redBalloons;


            /*
            19. There are 38 books on the shelf. Marta put 10 more books on the shelf.
            How many books are on the shelf now?
            */
            int booksOnShelf = 38;
            int booksPlacedOnShelf = 10;
            int totalBooks = booksOnShelf + booksPlacedOnShelf;


            /*
            20. A bee has 6 legs. How many legs do 8 bees have?
            */
            int beeLegs = 6;
            int totalBees = 8;
            int totalLegs = beeLegs * totalBees;


            /*
            21. Mrs. Hilt bought an ice cream cone for 99 cents. How much would 2 ice
            cream cones cost?
            */
            decimal icecreamConePrice = 0.99M;
            int numIcecreamCones = 2;
            decimal costOfConesHilt = icecreamConePrice * numIcecreamCones;


            /*
            22. Mrs. Hilt wants to make a border around her garden. She needs 125
            rocks to complete the border. She has 64 rocks. How many more rocks
            does she need to complete the border?
            */
            int rocksForBorder = 125;
            int rocksHiltHas = 64;
            int rocksNeededForGarden = rocksForBorder - rocksHiltHas;
            /*
            23. Mrs. Hilt had 38 marbles. She lost 15 of them. How many marbles does
            she have left?
            */
            int marblesHiltHas = 38;
            int marblesHiltLost = 15;
            int marblesRemaining = marblesHiltHas - marblesHiltLost;


            /*
            24. Mrs. Hilt and her sister drove to a concert 78 miles away. They drove 32
            miles and then stopped for gas. How many miles did they have left to drive?
            */
            int distConcert = 78;
            int distGas = 32;
            int distRemain = distConcert - distGas;


            /*
            25. Mrs. Hilt spent 1 hour and 30 minutes shoveling snow on Saturday
            morning and 45 minutes shoveling snow on Saturday afternoon. How
            much total time did she spend shoveling snow?
            */
            int timeSatHrs = 1;
            int timeSatMins = 30;
            int timeSunHrs = 0;
            int timeSunMins = 45;
            int minInHrs = 60;
            int timeShovelingHrs = timeSatHrs + timeSunHrs + (timeSatMins + timeSunMins)/minInHrs;
            int timeShovelingMins = (timeSatMins + timeSunMins) % minInHrs;
            Console.WriteLine(timeShovelingHrs + " hours" + " and " + timeShovelingMins + " minutes");


            /*    
            26. Mrs. Hilt bought 6 hot dogs. Each hot dog cost 50 cents. How much
            money did she pay for all of the hot dogs?
            */
            decimal hotDogPrice = 0.50M;
            int numHotDogs = 6;
            decimal pricePaid = hotDogPrice * numHotDogs;

            /*
            27. Mrs. Hilt has 50 cents. A pencil costs 7 cents. How many pencils can
            she buy with the money she has?
            */
            decimal pricePencil= 0.07M;
            decimal cashHiltforPencils = 0.50M;
            int numPencils = (int)(cashHiltforPencils / pricePencil);


            /*    
            28. Mrs. Hilt saw 33 butterflies. Some of the butterflies were red and others
            were orange. If 20 of the butterflies were orange, how many of them
            were red?
            */
            int hiltsButterflies = 33;
            int orangeButteryflies = 20;
            int redButterflies = hiltsButterflies - orangeButteryflies;


            /*    
            29. Kate gave the clerk $1.00. Her candy cost 54 cents. How much change
            should Kate get back?
            */
            double kateMoney = 1.00;
            double candyCost = 0.54;
            double changeForKate = kateMoney - candyCost;

            /*
            30. Mark has 13 trees in his backyard. If he plants 12 more, how many trees
            will he have?
            */
            int treesMarkYard = 13;
            int treesMarkPlants = 12;
            int treesTotalMarksYard = treesMarkPlants + treesMarkYard;


            /*    
            31. Joy will see her grandma in two days. How many hours until she sees
            her?
            */
            int hoursInDay = 24;
            int daysUntilVisit = 2;
            int timeJoyvisitGrandma = daysUntilVisit * hoursInDay;


            /*
            32. Kim has 4 cousins. She wants to give each one 5 pieces of gum. How
            much gum will she need?
            */
            int kimCousins = 4;
            int piecesGum = 5;
            int gumNeeded = kimCousins * piecesGum;


            /*
            33. Dan has $3.00. He bought a candy bar for $1.00. How much money is
            left?
            */
            double cashDan = 3.00;
            double candyBar = 1.00;
            double cashRemainingDan = cashDan - candyBar;


            /*
            34. 5 boats are in the lake. Each boat has 3 people. How many people are
            on boats in the lake?
            */
            int boatInLake = 5;
            int boatPassengers = 3;
            int peopleOnLake = boatInLake * boatPassengers;


            /*
            35. Ellen had 380 legos, but she lost 57 of them. How many legos does she
            have now?
            */
            int legosEllenHas = 380;
            int legosEllenLost = 57;
            int legosEllenRemaining = legosEllenHas - legosEllenLost;


            /*
            36. Arthur baked 35 muffins. How many more muffins does Arthur have to
            bake to have 83 muffins?
            */
            int muffinsBaked = 35;
            int muffinsNeeded = 83;
            int muffinsDifference = muffinsNeeded - muffinsBaked;


            /*
            37. Willy has 1400 crayons. Lucy has 290 crayons. How many more
            crayons does Willy have then Lucy?
            */
            int crayonsWilly = 1400;
            int crayonsLucy = 290;
            int crayonSeparation = crayonsWilly - crayonsLucy;


            /*
            38. There are 10 stickers on a page. If you have 22 pages of stickers, how
            many stickers do you have?
            */
            int stickersPerPage = 10;
            int pagesOfStickers = 22;
            int stickersTotal = stickersPerPage * pagesOfStickers;


            /*
            39. There are 96 cupcakes for 8 children to share. How much will each
            person get if they share the cupcakes equally?
            */
            int cupcakesShared = 96;
            int numberOfChildren = 8;
            int equallySharedCupcakes = cupcakesShared / numberOfChildren;


            /*
            40. She made 47 gingerbread cookies which she will distribute equally in
            tiny glass jars. If each jar is to contain six cookies each, how many
            cookies will not be placed in a jar?
            */
            int gingerbreadCookiesMade = 47;
            int cookiesPerJar = 6;
            int cookiesNotInJars = gingerbreadCookiesMade % cookiesPerJar;
            Console.WriteLine(cookiesNotInJars);

            /*
            41. She also prepared 59 croissants which she plans to give to her 8
            neighbors. If each neighbor received and equal number of croissants,
            how many will be left with Marian?
            */
            int croissantsMade = 59;
            int neighborQuantity = 8;
            int divideCroissants = croissantsMade % neighborQuantity;
            Console.WriteLine(divideCroissants);


            /*
            42. Marian also baked oatmeal cookies for her classmates. If she can
            place 12 cookies on a tray at a time, how many trays will she need to
            prepare 276 oatmeal cookies at a time?
            */
            int totalCookiesNeeded = 276;
            int cookiesPerTray = 12;
            int traysTrayQuantity = totalCookiesNeeded / cookiesPerTray;


            /*
            43. Marian’s friends were coming over that afternoon so she made 480
            bite-sized pretzels. If one serving is equal to 12 pretzels, how many
            servings of bite-sized pretzels was Marian able to prepare?
            */
            int pretzelsMade = 480;
            int pretzelServingSize = 12;
            int pretzelServingsPrepared = pretzelsMade / pretzelServingSize;

            /*
            44. Lastly, she baked 53 lemon cupcakes for the children living in the city
            orphanage. If two lemon cupcakes were left at home, how many
            boxes with 3 lemon cupcakes each were given away?
            */
            int cupcakesForOrphans = 53;
            int cupcakesPerBox = 3;
            int cupcakeBoxesDelivered = cupcakesForOrphans / cupcakesPerBox;


            /*
            45. Susie's mom prepared 74 carrot sticks for breakfast. If the carrots
            were served equally to 12 people, how many carrot sticks were left
            uneaten?
            */
            int carrotsPrepaired = 74;
            int carrotsPerPerson = 12;
            int carrotsRemaining = carrotsPrepaired % carrotsPerPerson;

            /*
            46. Susie and her sister gathered all 98 of their teddy bears and placed
            them on the shelves in their bedroom. If every shelf can carry a
            maximum of 7 teddy bears, how many shelves will be filled?
            */
            int combinedTeddyBears = 98;
            int teddyBearsPerShelf = 7;
            int numberShelfsFilled = combinedTeddyBears / teddyBearsPerShelf;


            /*
            47. Susie’s mother collected all family pictures and wanted to place all of
            them in an album. If an album can contain 20 pictures, how many
            albums will she need if there are 480 pictures?
            */
            int familyPhotos = 480;
            int photosInAlbum = 20;
            int albumQuantity = familyPhotos / photosInAlbum;

            /*
            48. Joe, Susie’s brother, collected all 94 trading cards scattered in his
            room and placed them in boxes. If a full box can hold a maximum of 8
            cards, how many boxes were filled and how many cards are there in
            the unfilled box?
            */
            int scatteredCards = 94;
            int cardsPerBox = 8;
            int boxesFilled = scatteredCards / cardsPerBox;
            int cardsRemaining = scatteredCards % cardsPerBox;

            /*
            49. Susie’s father repaired the bookshelves in the reading room. If he has
            210 books to be distributed equally on the 10 shelves he repaired,
            how many books will each shelf contain?
            */
            int bookCollectionCount = 210;
            int shelfQuantity = 10;
            int booksPerShelf = bookCollectionCount / shelfQuantity;


            /*
            50. Cristina baked 17 croissants. If she planned to serve this equally to
            her seven guests, how many will each have?
            */
            int croissantsByChristina = 17;
            int guestsOfChristina = 7;
            int croissantsDistributedEachGuest = croissantsByChristina / guestsOfChristina;
            Console.WriteLine("croisants " + croissantsDistributedEachGuest);

            /*
                CHALLENGE PROBLEMS
            */

            /*
            Bill and Jill are house painters. Bill can paint a 12 x 14 room in 2.15 hours, while Jill averages 
            1.90 hours. How long will it take the two painter working together to paint 5 12 x 14 rooms?
            Hint: Calculate the hourly rate for each painter, combine them, and then divide the total walls in feet by the combined hourly rate of the painters.
            Challenge: How many days will it take the pair to paint 623 rooms assuming they work 8 hours a day?.
            */
            double timeBill = 2.15;
            double timeJill = 1.90;
            decimal paintRateBill = 1 / (decimal)timeBill; //rate or 1 room over time to complete 
            decimal paintRateJill = 1 / (decimal)timeJill;
            Console.WriteLine("paintRateBill: " + paintRateBill);
            int roomsToPaintCombined = 5;
            double combinedTime5Rooms = roomsToPaintCombined / (double)(paintRateBill + paintRateJill);
            Console.WriteLine("combinedTime5Rooms: " + combinedTime5Rooms);

            //time to paint 623 rooms working 8 hour days
            int hoursPerDay = 8;
            int roomsToPaintChallenge = 623;
            double combinedRoomsPerDay = (double)(paintRateBill + paintRateJill)*hoursPerDay;
            double daysToComplete623Rooms = roomsToPaintChallenge / combinedRoomsPerDay;
            Console.WriteLine("daysToComplete623Rooms: " + daysToComplete623Rooms);



            /*
            Create and assign variables to hold your first name, last name, and middle initial. Using concatenation,
            build an additional variable to hold your full name in the order of last name, first name, middle initial. The
            last and first names should be separated by a comma followed by a space, and the middle inital must end
            with a period.
            Example: "Hopper, Grace B." 
            */
            string firstName = "Austin";
            string lastName = "Warner";
            char middleInitial = 'L';
            string fullName = lastName + ", " + firstName + " " + middleInitial + ".";
            Console.WriteLine(fullName);


            /*
            The distance between New York and Chicago is 800 miles, and the train has already travelled 537 miles. 
            What percentage of the trip has been completed?
            Hint: The percent completed is the miles already travelled divided by the total miles.
            Challenge: Display as an integer value between 0 and 100 using casts.
            */

        }
    }
}
