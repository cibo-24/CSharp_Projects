using System.Collections.Generic;
using System;

namespace ZorSeviyeUygulamalar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pre-defined kategoriler oluştur
            List<Category> categories = new List<Category>();
            categories.Add(new Category("Film Kategorileri"));
            categories.Add(new Category("Tech Stack Kategorileri"));
            categories.Add(new Category("Spor Kategorileri"));

            // Kullanıcının username'ini iste
            Console.Write("Kullanıcı adınız: ");
            string username = Console.ReadLine();

            // Kullanıcının kayıtlı olup olmadığını kontrol et
            User user = User.GetUserByUsername(username);
            if (user == null)
            {
                // Kullanıcı kayıtlı değilse, kaydını yap
                user = new User(username);
                User.Users.Add(user);
                Console.WriteLine("Yeni kullanıcı kaydedildi.");
            }

            // Kullanıcının oylama yapması için tüm kategorileri göster
            Console.WriteLine("Aşağıdaki kategorilerden birini seçin:");

            for (int i = 0; i < categories.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {categories[i].Name}");
            }

            // Kullanıcının seçtiği kategoriye oy ver
            Console.Write("Seçiminiz (1-3): ");
            int choice = int.Parse(Console.ReadLine());

            categories[choice - 1].Votes++;
            Console.WriteLine($"Teşekkürler, {username}. Oyunuz kaydedildi.");

            // Kategorilerin toplam oylarını hesapla
            int totalVotes = 0;
            foreach (Category category in categories)
            {
                totalVotes += category.Votes;
            }

            // Kategorilerin oylama sonuçlarını ekrana yazdır
            Console.WriteLine("KATEGORI\t\t\t\t OY SAYISI\t\t OY ORANI");
            foreach (Category category in categories)
            {
                double votePercentage = (double)category.Votes / totalVotes * 100;
                Console.WriteLine($"{category.Name,-40} {category.Votes,-20} {votePercentage,5:N2}%");
            }

            Console.WriteLine("Program sonlandı. Çıkmak için ENTER tuşuna basın.");
            Console.ReadLine();
        }
    }

    class Category
    {
        public string Name { get; set; }
        public int Votes { get; set; }

        public Category(string name)
        {
            Name = name;
            Votes = 0;
        }
    }

    class User
    {
        public static List<User> Users = new List<User>();

        public string Username { get; set; }

        public User(string username)
        {
            Username = username;
        }

        public static User GetUserByUsername(string username)
        {
            foreach (User user in Users)
            {
                if (user.Username == username)
                {
                    return user;
                }
            }

            return null;
        }
    }
}
