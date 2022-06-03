using CruiseDTO;

using CommonDataDTO;

namespace CruiseDAL
{
    public class FakeData
    {
        private static FakeData? Singleton;

        #region création des données de références
        internal static readonly CruiseLine[] cruiseLines =
        {
            new CruiseLine(new Guid("9501baa2-5f6a-4449-bc88-bea8ad24a9dd"), "FirstLine"),
            new CruiseLine(new Guid("a302f7cd-11a5-43f6-a9ca-241764ebcc94"), "SecondLine"),
            new CruiseLine(new Guid("7ac5d12d-5ab2-4c91-86af-4f495291d0ba"), "ThirdLine")
        };

        internal static readonly Port[] ports =
        {
            new Port(new Guid("c9f9cad7-e163-4e2a-bade-a275fe4cb674"), "Port de Montréal", new Address(new Guid(), new Country("Canada"), new Region("Québec"), new City("Montréal"), new PostalCode("H0H0H0"), "123 rue Rue")),
            new Port(new Guid("6e2ced92-25c0-4ed6-b9c8-3082347f8df3"), "WhiteBoomer", new Address(new Guid(), new Country("États-Unis"), new Region("Floride"), new City("Snowbird City"), new PostalCode("99577-0727"), "777 Jesus Street")),
            new Port(new Guid("7bb04441-d69c-476f-98c1-aa05682a15d8"), "Clandestin", new Address(new Guid(), new Country("Colombie"), new Region("Valle del Cauca"), new City("Buenaventura"), new PostalCode("C0C0C0"), "666 ElDiablo")),
            new Port(new Guid("917b7a3a-5387-4685-bb54-98013b5823e3"), "PetitPain", new Address(new Guid(), new Country("France"), new Region("Bretagne"), new City("Brest"), new PostalCode("9FJW+C9"), "Rte de la Corniche, 29200")),
            new Port(new Guid("729e800e-635c-48bc-9904-c599f76f5e7d"), "YellowMollow", new Address(new Guid(), new Country("Chine"), new Region("Shanghai"), new City("Shanghai"), new PostalCode("TooManyDigits"), ""))
        };

        internal static readonly Ship[] ships =
        {
            new Ship(new Guid("a6cd5b8a-4c5f-47ae-97df-ceb7d7656aa6"), "BiggusFloatus", ports[0], cruiseLines[0]),
            new Ship(new Guid("479b8037-fe8e-45c6-84b1-7a98a9bb7ce9"), "PetiteChaloupe", ports[1], cruiseLines[1]),
            new Ship(new Guid("ff70de0b-5983-4a64-8a8f-72b1f9939d85"), "Titanic", ports[2], cruiseLines[2]),
            new Ship(new Guid("52ddb7d7-bf66-4a55-bf17-7dc7c4a9d7d9"), "Pédalo", ports[3], cruiseLines[0]),
            new Ship(new Guid("68946a6b-9b55-4462-a31a-2fc08d68f1c7"), "Liberty", ports[4], cruiseLines[1]),
            new Ship(new Guid("5041f33a-9117-47fc-a82d-fef6bc30c120"), "Partouze", ports[4], cruiseLines[2])
        };

        internal static readonly Deck[] decks =
        {
            new Deck(new Guid(), ships[0], "Un"),
            new Deck(new Guid(), ships[0], "Deux"),
            new Deck(new Guid(), ships[1], "Uno"),
            new Deck(new Guid(), ships[1], "Dos"),
            new Deck(new Guid(), ships[2], "Primo"),
            new Deck(new Guid(), ships[2], "Secondu"),
            new Deck(new Guid(), ships[3], "First"),
            new Deck(new Guid(), ships[3], "Second"),
            new Deck(new Guid(), ships[4], "FilledWithHoles"),
            new Deck(new Guid(), ships[4], "RIP")
        };

        internal static readonly CabinType[] cabinTypes =
        {
            new CabinType(new Guid("15aadf5d-ccb9-4ad7-bb63-8d047ab87860"), "Stateroom"),
            new CabinType(new Guid("1c29d2c0-ca3c-42b0-a7c7-4efdfeaa8f42"), "Ocean View Cabins"),
            new CabinType(new Guid("4b0ceff4-3726-4870-814e-365cf94c5a0f"), "Balcony Cabins"),
            new CabinType(new Guid("35b223e0-2af0-4f83-82b2-b654c33ef354"), "Suites"),
            new CabinType(new Guid("23f2e79b-0ecc-4e8d-9c6a-4aef35026a95"), "Solo Cabins")
        };

        internal static readonly Cabin[] cabins =
        {
            new Cabin(new Guid("37f62f67-6c89-4d81-9261-afc29756349a"), decks[0], cabinTypes[0], "1"),
            new Cabin(new Guid("8451a18a-07ee-41dc-b948-cba4a4126b4b"), decks[0], cabinTypes[0], "2"),
            new Cabin(new Guid("d515ded3-321b-42c5-996e-d64848e9606f"), decks[1], cabinTypes[0], "3"),
            new Cabin(new Guid("17cae45e-bf72-4224-9c68-7120baefd20f"), decks[1], cabinTypes[0], "4"),
            new Cabin(new Guid("8762c6cf-9902-4080-ab1c-51e3b3a79b73"), decks[2], cabinTypes[1], "5"),
            new Cabin(new Guid("bcc864c6-31b3-4b92-a76d-8979ebc98a7a"), decks[2], cabinTypes[1], "6"),
            new Cabin(new Guid("7b390c7a-f151-4bce-95b9-b56040f8cf19"), decks[3], cabinTypes[1], "7"),
            new Cabin(new Guid("1d38e0f0-1ecb-42b1-babc-fdcda18fd85f"), decks[3], cabinTypes[1], "8"),
            new Cabin(new Guid("dc9670c4-60e1-4bae-a92d-36c40dc71ed2"), decks[4], cabinTypes[2], "9"),
            new Cabin(new Guid("f42d2db3-09dc-47ff-a9dd-17a5a784e078"), decks[4], cabinTypes[2], "10"),
            new Cabin(new Guid("cbf9115c-a4cf-4623-ad02-d197216de105"), decks[5], cabinTypes[2], "11"),
            new Cabin(new Guid("b1f78051-d1e9-4b6b-bec4-663811774a41"), decks[5], cabinTypes[2], "12"),
            new Cabin(new Guid("bb1cbe81-47b7-445b-9562-5ad3619983b2"), decks[6], cabinTypes[3], "13"),
            new Cabin(new Guid("70936dd6-d5d1-44d6-b78a-dbc425776954"), decks[6], cabinTypes[3], "14"),
            new Cabin(new Guid("0fb88f78-7169-4caa-affe-64bfcbfc1f8d"), decks[7], cabinTypes[3], "15"),
            new Cabin(new Guid("4fc48068-1bca-4f55-ae83-a26d519883f1"), decks[7], cabinTypes[3], "16"),
            new Cabin(new Guid("8131d8fb-0b15-485c-8688-d14af485434a"), decks[8], cabinTypes[4], "17"),
            new Cabin(new Guid("ef81df9b-18fa-466d-9ceb-e6d06767c38d"), decks[8], cabinTypes[4], "18"),
            new Cabin(new Guid("10c6ba5e-245f-48de-b234-000fe66acde3"), decks[9], cabinTypes[4], "19"),
            new Cabin(new Guid("3600300d-0078-4be3-a104-117b5859477a"), decks[9], cabinTypes[4], "20")
        };

        internal static readonly Cruise[] cruises =
        {
            new Cruise(new Guid("d26e0135-63dd-404a-97c0-7c0d8f7d09dd"), ships[0], decks[0], cabinTypes[0], ports[0], new DateTime(2022, 09, 19, 10, 45, 0), ports[1], new DateTime(2022, 09, 26, 10, 45, 0)),
            new Cruise(new Guid("29b5bec4-4cd6-4908-8575-df327348947e"), ships[0], decks[0], cabinTypes[0], ports[0], new DateTime(2022, 09, 19, 12, 45, 0), ports[2], new DateTime(2022, 09, 26, 12, 45, 0)),
            new Cruise(new Guid("df96c7cc-c940-45a9-b1bf-8dd3022687b2"), ships[0], decks[1], cabinTypes[0], ports[0], new DateTime(2022, 09, 19, 14, 45, 0), ports[3], new DateTime(2022, 09, 26, 14, 45, 0)),
            new Cruise(new Guid("09881d94-2878-4592-9f97-2334f1f0b81d"), ships[0], decks[1], cabinTypes[0], ports[0], new DateTime(2022, 09, 19, 16, 45, 0), ports[4], new DateTime(2022, 09, 26, 16, 45, 0)),
            new Cruise(new Guid("821efd0d-ba87-42ec-8120-51bd5390ea15"), ships[1], decks[2], cabinTypes[0], ports[1], new DateTime(2022, 09, 19, 18, 45, 0), ports[0], new DateTime(2022, 09, 26, 18, 45, 0)),
            new Cruise(new Guid("ea2cf1a0-adc5-4d3b-90ee-84e79db55130"), ships[1], decks[2], cabinTypes[1], ports[1], new DateTime(2022, 09, 19, 20, 45, 0), ports[2], new DateTime(2022, 09, 26, 20, 45, 0)),
            new Cruise(new Guid("7d8a5e93-b3c9-4bbb-bfed-b4a9473023f1"), ships[1], decks[3], cabinTypes[1], ports[1], new DateTime(2022, 09, 19, 22, 45, 0), ports[3], new DateTime(2022, 09, 26, 22, 45, 0)),
            new Cruise(new Guid("cf58e214-4584-42c6-b2b2-70459b4fdda4"), ships[1], decks[3], cabinTypes[1], ports[1], new DateTime(2022, 10, 24, 10, 30, 0), ports[4], new DateTime(2022, 10, 31, 10, 30, 0)),
            new Cruise(new Guid("6c024af0-1494-47a8-a656-e9a2f57d9c2c"), ships[2], decks[4], cabinTypes[1], ports[2], new DateTime(2022, 10, 24, 10, 30, 0), ports[0], new DateTime(2022, 10, 31, 10, 30, 0)),
            new Cruise(new Guid("86181165-8149-4123-ae85-a5d62f894c63"), ships[2], decks[4], cabinTypes[1], ports[2], new DateTime(2022, 10, 24, 10, 30, 0), ports[1], new DateTime(2022, 10, 31, 10, 30, 0)),
            new Cruise(new Guid("af4aee89-5793-412d-91db-1241929588a9"), ships[2], decks[5], cabinTypes[2], ports[2], new DateTime(2022, 10, 24, 10, 30, 0), ports[3], new DateTime(2022, 10, 31, 10, 30, 0)),
            new Cruise(new Guid("d8f91a09-d7a2-4bb7-85e9-68fd1867a139"), ships[2], decks[5], cabinTypes[2], ports[2], new DateTime(2022, 10, 24, 10, 30, 0), ports[4], new DateTime(2022, 10, 31, 10, 30, 0)),
            new Cruise(new Guid("992cf2ec-302d-4e7a-8d86-8edf13e55c93"), ships[3], decks[6], cabinTypes[2], ports[3], new DateTime(2022, 11, 12, 20, 15, 0), ports[0], new DateTime(2022, 11, 19, 20, 15, 0)),
            new Cruise(new Guid("4cfec78e-fabe-4b8e-8f59-5b857088c00e"), ships[3], decks[6], cabinTypes[2], ports[3], new DateTime(2022, 11, 12, 20, 15, 0), ports[1], new DateTime(2022, 11, 19, 20, 15, 0)),
            new Cruise(new Guid("879eb1bb-6862-43aa-b5de-b39196bb2727"), ships[3], decks[7], cabinTypes[2], ports[3], new DateTime(2022, 11, 12, 20, 15, 0), ports[2], new DateTime(2022, 11, 19, 20, 15, 0)),
            new Cruise(new Guid("d8b8471f-9126-4b7c-988b-683a1e2bb8dc"), ships[3], decks[7], cabinTypes[3], ports[3], new DateTime(2022, 11, 12, 20, 15, 0), ports[4], new DateTime(2022, 11, 19, 20, 15, 0)),
            new Cruise(new Guid("13e670f9-684a-41e6-8144-5876d2d47d6c"), ships[4], decks[8], cabinTypes[3], ports[4], new DateTime(2022, 11, 12, 20, 15, 0), ports[0], new DateTime(2022, 11, 19, 20, 15, 0)),
            new Cruise(new Guid("5604174e-956b-4d24-a225-cd5083491a64"), ships[4], decks[8], cabinTypes[3], ports[4], new DateTime(2022, 12, 25, 11,  0, 0), ports[1], new DateTime(2023, 01, 01, 11,  0, 0)),
            new Cruise(new Guid("38f40dc2-4ede-4b7c-9476-36e3af1bbf1e"), ships[4], decks[9], cabinTypes[3], ports[4], new DateTime(2022, 12, 25, 11,  0, 0), ports[2], new DateTime(2023, 01, 01, 11,  0, 0)),
            new Cruise(new Guid("5750b9b4-6516-42c2-bbc7-5b26e1e7e138"), ships[4], decks[9], cabinTypes[3], ports[4], new DateTime(2022, 12, 25, 11,  0, 0), ports[3], new DateTime(2023, 01, 01, 11,  0, 0)),
            new Cruise(new Guid("c5609828-cd7b-4847-bdae-7c8f02c9c6d2"), ships[0], decks[1], cabinTypes[4], ports[0], new DateTime(2022, 12, 25, 11,  0, 0), ports[4], new DateTime(2023, 01, 01, 11,  0, 0)),
            new Cruise(new Guid("89d9c0f7-5837-4702-bf4e-e4be9c7dc4a3"), ships[1], decks[3], cabinTypes[4], ports[1], new DateTime(2022, 12, 25, 11,  0, 0), ports[3], new DateTime(2023, 01, 01, 11,  0, 0)),
            new Cruise(new Guid("45b13cb8-6aa0-4a46-95c6-fb018991733a"), ships[2], decks[5], cabinTypes[4], ports[2], new DateTime(2023, 01, 10, 12, 30, 0), ports[2], new DateTime(2023, 01, 17, 12, 30, 0)),
            new Cruise(new Guid("3983671e-6500-4f4f-9cf1-d59075663dda"), ships[3], decks[7], cabinTypes[4], ports[3], new DateTime(2024, 02, 11, 12, 30, 0), ports[1], new DateTime(2024, 02, 18, 12, 30, 0)),
            new Cruise(new Guid("7d885a33-c2af-43e0-9e76-23077d8b35db"), ships[4], decks[9], cabinTypes[4], ports[4], new DateTime(2025, 03, 12, 12, 30, 0), ports[0], new DateTime(2025, 03, 19, 12, 30, 0))
        };

        #endregion


        // Utilisez des GUID statiques (fake) pour les distinguer
        // https://www.guidgenerator.com/online-guid-generator.aspx

        // TODO Simuler de la disponibilité. Attention, les disponibilités (Availability)
        // ne doivent pas être statiques puis qu'on doit voir 
        // la disponibilité changer après une réservation


        internal static FakeData GetInstance()
        {
            if (Singleton == null) Singleton = new FakeData();
            return Singleton;
        }
    }
}