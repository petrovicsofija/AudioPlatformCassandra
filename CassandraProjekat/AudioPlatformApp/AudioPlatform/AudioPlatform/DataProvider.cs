using AudioPlatform.QueryEntities;
using Cassandra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlatform
{
    public static class DataProvider
    {
        #region AudioPlatform
        public static Audioplatform GetPlatform(string name)
        {
            ISession session = SessionManager.GetSession();
            Audioplatform platform = new Audioplatform();

            if (session == null)
                return null;

            Row platformData = session.Execute("select * from \"AudioPlatform\" where name ='" + name+"'").FirstOrDefault();

            if (platformData != null)
            {
                platform.name = platformData["name"] != null ? platformData["name"].ToString() : string.Empty;
                platform.price = (double)(platformData["price"] != null ? platformData["price"] : 0);
                platform.description = platformData["description"] != null ? platformData["description"].ToString() : string.Empty;
            }

            return platform;
        }

        public static List<Audioplatform> GetPlatforms()
        {
            ISession session = SessionManager.GetSession();
            List<Audioplatform> platformList = new List<Audioplatform>();


            if (session == null)
                return null;

            var platforms = session.Execute("select * from \"AudioPlatform\"");


            foreach (var platformData in platforms)
            {
                Audioplatform platform = new Audioplatform();
                platform.name = platformData["name"] != null ? platformData["name"].ToString() : string.Empty;
                platform.price = (double)(platformData["price"] != null ? platformData["price"] : 0);
                platform.description = platformData["description"] != null ? platformData["description"].ToString() : string.Empty;
                platformList.Add(platform);
            }



            return platformList;
        }

        public static void AddPlatform(Audioplatform platform) //postoji funkcija ali logika aplikacije je ne zahteva jer ne moze se tako dodati platforma bilo bi glupo
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet data = session.Execute("insert into \"AudioPlatform\" (name, price,description) values ('"+platform.name +"'," + platform.price + "'," +platform.description +"')");

        }

        public static void DeletePlatform(string name)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet data = session.Execute("delete from \"AudioPlatform\" where name = '" + name+"'");

        }
        public static void UpdatePlatformPrice(string name, string newPrice)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet platformData = session.Execute("update \"AudioPlatform\" set price =" + Convert.ToDouble(newPrice) + " where name = '" + name+"'");

        }
        #endregion

        #region Song
        public static Song GetSong(string name,string autor,string tier)
        {
            ISession session = SessionManager.GetSession();
            Song song = new Song();

            if (session == null)
                return null;

            Row data = session.Execute("select * from \"Song\" where name='" + name+"' and autor='"+autor+"' and audio_tier='"+tier+"'").FirstOrDefault();

            if (data != null)
            {
                song.name = data["name"] != null ? data["name"].ToString() : string.Empty;
                song.autor = data["autor"] != null ? data["autor"].ToString() : string.Empty;
                song.audio_tier = data["audio_tier"] != null ? data["audio_tier"].ToString() : string.Empty;
                song.url = data["url"] != null ? data["url"].ToString() : string.Empty;
                song.genre = data["genre"] != null ? data["genre"].ToString() : string.Empty;
            }

            return song;
        }

        public static List<Song> GetSongs()
        {
            ISession session = SessionManager.GetSession();
            List<Song> list = new List<Song>();


            if (session == null)
                return null;

            var songs = session.Execute("select * from \"Song\"");


            foreach (var data in songs)
            {
                Song song = new Song();
                song.name = data["name"] != null ? data["name"].ToString() : string.Empty;
                song.autor = data["autor"] != null ? data["autor"].ToString() : string.Empty;
                song.audio_tier = data["audio_tier"] != null ? data["audio_tier"].ToString() : string.Empty;
                song.url = data["url"] != null ? data["url"].ToString() : string.Empty;
                song.genre = data["genre"] != null ? data["genre"].ToString() : string.Empty;
                list.Add(song);
            }



            return list;
        }

        public static void AddSong(Song song)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet data = session.Execute("insert into \"Song\" (url,name,autor,genre, audio_tier) values ('" + song.url + "','" + song.name + "','" + song.autor + "','" + song.genre + "','"+ song.audio_tier+"')");

        }

        public static void DeleteSong(string name,string autor,string tier)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet data = session.Execute("delete from \"Song\"  where name='" + name + "' and autor='" + autor + "' and audio_tier='" + tier+"'");

        }
        #endregion

        #region Contract

        public static Contract GetContract(string startDate,string audioTier,string customer_name, string customer_surname)
        {
            ISession session = SessionManager.GetSession();
            Contract contract = new Contract();

            if (session == null)
                return null;

            Row contractData = session.Execute("select * from \"Contract\" where start_date = '" + startDate + "' and audio_tier ='" + audioTier + "' and customer_name='" + customer_name + "' and customer_surname ='" + customer_surname + "'").FirstOrDefault();

            if (contractData != null)
            {
                contract.start_date = contractData["start_date"] != null ? contractData["start_date"].ToString() : string.Empty;
                contract.end_date = contractData["end_date"] != null ? contractData["end_date"].ToString() : string.Empty;
                contract.audio_tier = contractData["audio_tier"] != null ? contractData["audio_tier"].ToString() : string.Empty;
                contract.customer_name = contractData["customer_name"] != null ? contractData["customer_name"].ToString() : string.Empty;
                contract.customer_surname = contractData["customer_surname"] != null ? contractData["customer_surname"].ToString() : string.Empty;
            }

            return contract;
        }


        public static List<Contract> GetContracts()
        {
            ISession session = SessionManager.GetSession();
            List<Contract> contracts = new List<Contract>();


            if (session == null)
                return null;

            var contractsData = session.Execute("select * from \"Contract\"");


            foreach (var contractData in contractsData)
            {
                Contract contract = new Contract();
                contract.start_date = contractData["start_date"] != null ? contractData["start_date"].ToString() : string.Empty;
                contract.end_date = contractData["end_date"] != null ? contractData["end_date"].ToString() : string.Empty;
                contract.audio_tier = contractData["audio_tier"] != null ? contractData["audio_tier"].ToString() : string.Empty;
                contract.customer_name = contractData["customer_name"] != null ? contractData["customer_name"].ToString() : string.Empty;
                contract.customer_surname = contractData["customer_surname"] != null ? contractData["customer_surname"].ToString() : string.Empty;
                contracts.Add(contract);
            }

            return contracts;
        }

        public static void AddContract(string startDate, string endDate, string audioTier, string customer_name,string customer_surname)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet contractData = session.Execute("insert into \"Contract\" (start_date, end_date, audio_tier, customer_name,customer_surname)  values ('"+startDate + "','" + endDate + "','" + audioTier + "','" + customer_name + "','" + customer_surname+"')");

        }

        public static void DeleteContract(string startDate,string audioTier, string customer_name, string customer_surname)
        {
            ISession session = SessionManager.GetSession();
            Contract contract = new Contract();

            if (session == null)
                return;

            RowSet hotelData = session.Execute("delete from \"Contract\" where start_date = '" + startDate+"' and audio_tier ='"+audioTier+"' and customer_name='"+customer_name+"' and customer_surname ='"+customer_surname+"'");

        }

        public static void UpdateContractDate(string newDate,string startDate, string audioTier, string customer_name, string customer_surname)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet customerData = session.Execute("update \"Contract\" set end_date ='" + newDate + "' where start_date = '" + startDate + "' and audio_tier ='" +audioTier +"' and customer_name ='"+ customer_name + "' and customer_surname='"+ customer_surname+"'");
        }

        #endregion

        #region Rating
        public static AudioTierRating GetAudioTierRating(string desc,string email)
        {
            ISession session = SessionManager.GetSession();
            AudioTierRating rate = new AudioTierRating();

            if (session == null)
                return null;

            Row data = session.Execute("select * from \"AudioTierRaiting\" where description='" + desc+"' and customer_email='"+email+"'").FirstOrDefault();

            if (data != null)
            {
                rate.description = data["description"] != null ? data["description"].ToString() : string.Empty;
                rate.evaluation = (double)(data["evaluation"] != null ? data["evaluation"] :0);
                rate.customer_name = data["customer_name"] != null ? data["customer_name"].ToString() : string.Empty;
                rate.customer_surname = data["customer_surname"] != null ? data["customer_surname"].ToString() : string.Empty;
                rate.customer_email = data["customer_email"] != null ? data["customer_email"].ToString() : string.Empty;
                rate.platform = data["platform"] != null ? data["platform"].ToString() : string.Empty;
            }

            return rate;
        }

        public static List<AudioTierRating> GetRatings()
        {
            ISession session = SessionManager.GetSession();
            List<AudioTierRating> list = new List<AudioTierRating>();


            if (session == null)
                return null;

            var ratings = session.Execute("select * from \"AudioTierRating\"");


            foreach (var data in ratings)
            {
                AudioTierRating rate = new AudioTierRating();
                rate.description = data["description"] != null ? data["description"].ToString() : string.Empty;
                rate.evaluation = (double)(data["evaluation"] != null ? data["evaluation"] : 0);
                rate.customer_name = data["customer_name"] != null ? data["customer_name"].ToString() : string.Empty;
                rate.customer_surname = data["customer_surname"] != null ? data["customer_surname"].ToString() : string.Empty;
                rate.customer_email = data["customer_email"] != null ? data["customer_email"].ToString() : string.Empty;
                rate.platform = data["platform"] != null ? data["platform"].ToString() : string.Empty;
                list.Add(rate);
            }
            return list;
        }

        public static void AddRate(AudioTierRating rate)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet data = session.Execute("insert into \"AudioTierRating\" (description,evaluation,customer_name,customer_surname,customer_email,platform) values ('" + rate.description + "'," + rate.evaluation + ",'" + rate.customer_name + "','" + rate.customer_surname+ "','" + rate.customer_email + "','" + rate.platform + "')");

        }

        public static void DeleteRate(string description,string email)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet data = session.Execute("delete from  \"AudioTierRating\"  where description='" + description+"' and customer_email='"+email+"'");

        }
        #endregion

        #region Customer

        public static Customer GetCustomer(string email,string password,string platform)
        {
            ISession session = SessionManager.GetSession();
            Customer customer = new Customer();

            if (session == null)
                return null;

            Row customerData = session.Execute("select * from \"Customer\" where email ='" + email + "' and password ='"+password+"' and audio_tier = '"+platform+"'").FirstOrDefault();

            if (customerData != null)
            { 
                customer.name = customerData["name"] != null ? customerData["name"].ToString() : string.Empty;
                customer.surname = customerData["surname"] != null ? customerData["surname"].ToString() : string.Empty;
                customer.email = customerData["email"] != null ? customerData["email"].ToString() : string.Empty;
                customer.password = customerData["password"] != null ? customerData["password"].ToString() : string.Empty;
                customer.birth_date = customerData["birth_date"] != null ? customerData["birth_date"].ToString() : string.Empty;
                customer.audio_price = (double)(customerData["audio_price"] != null ? customerData["audio_price"] : 0);
                customer.audio_tier = customerData["audio_tier"] != null ? customerData["audio_tier"].ToString() : string.Empty;
                customer.contract_end_date = customerData["contract_end_date"] != null ? customerData["contract_end_date"].ToString() : string.Empty;
                customer.contract_start_date = customerData["contract_start_date"] != null ? customerData["contract_start_date"].ToString() : string.Empty;
            }

            return customer;
        }


        public static List<Customer> GetCustomers()
        {
            ISession session = SessionManager.GetSession();
            List<Customer> customers = new List<Customer>();


            if (session == null)
                return null;

            var customersData = session.Execute("select * from \"Customer\"");


            foreach (var customerData in customersData)
            {
                Customer customer = new Customer();
                customer.name = customerData["name"] != null ? customerData["name"].ToString() : string.Empty;
                customer.surname = customerData["surname"] != null ? customerData["surname"].ToString() : string.Empty;
                customer.email = customerData["email"] != null ? customerData["email"].ToString() : string.Empty;
                customer.password = customerData["password"] != null ? customerData["password"].ToString() : string.Empty;
                customer.birth_date = customerData["birth_date"] != null ? customerData["birth_date"].ToString() : string.Empty;
                customer.audio_price = (double)(customerData["audio_price"] != null ? customerData["audio_price"] : 0);
                customer.audio_tier = customerData["audio_tier"] != null ? customerData["audio_tier"].ToString() : string.Empty;
                customer.contract_end_date = customerData["contract_end_date"] != null ? customerData["contract_end_date"].ToString() : string.Empty;
                customer.contract_start_date = customerData["contract_start_date"] != null ? customerData["contract_start_date"].ToString() : string.Empty;
                customers.Add(customer);
            }

            return customers;
        }

        public static void AddCustomer(string name, string surname, string email, string birth_date,string password, string audio_tier,double price, string contract_start,string contract_end)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet customerData = session.Execute("insert into \"Customer\" (name, surname, email,birth_date,password,audio_tier,audio_price,contract_start_date,contract_end_date)  values ('" + name + "','" + surname + "','" + email + "','" + birth_date + "','"+ password + "','" + audio_tier + "'," + price+",'"+ contract_start+ "','"+contract_end+"')");

        }

        public static void DeleteCustomer(string email)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet customerData = session.Execute("delete from \"Customer\" where email = '" + email+"'");

        }
        //public static void UpdateCustomerPassword(string email, String password)
        //{
        //    ISession session = SessionManager.GetSession();

        //    if (session == null)
        //        return;

        //    RowSet customerData = session.Execute("update \"Customer\" set password ='" + password+ "' where email = '" + email+"'");
        //}
        #endregion

    }
}
