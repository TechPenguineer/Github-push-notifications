using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Toolkit.Uwp.Notifications;

namespace GithubPushNotifications
{
    class notificationer
    {
        public void access_api()
        {

        }
        public void create_new_config_option()
        {
          string appdata=Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
          string config_dir = appdata + "\\.gpn";
          string config_users = config_dir + "\\followed_users.xml";
          string config_repos = config_dir + "\\followed_repos.xml";

            if(!Directory.Exists(config_dir))
            {
                Directory.CreateDirectory(config_dir);
                Console.WriteLine($"Created {config_dir}");

            }
            else 
            {
                if(!File.Exists(config_users))
                {
                    File.Create(config_users);
                    Console.WriteLine($"Created {config_users}");
                }
                if(!File.Exists(config_repos))
                {
                    File.Create(config_repos);
                    Console.WriteLine($"Created {config_repos}");

                }
            }


        }
        public void create_notification()
        {
            string Username,GithubRepo;
            Username = "TechPenguineer";
            GithubRepo = "Github-push-notifications";

            string notification_type_commit = $"{Username} just made a commit to {GithubRepo}";
            new ToastContentBuilder()
                .AddText("Github Push Notifications")
                .AddText(notification_type_commit)
                .Show();
        }
    }
}
