using System;
using System.Collections.Generic;
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
