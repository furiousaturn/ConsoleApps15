using System;
using System.Collections.Generic;
using System.Text;
using ConsoleHelpers;

namespace ConsoleAppProject.App04
{
    public class NetworkApp
    {
        private NewsFeed news = new NewsFeed();

        
        
        /// <summary>
        /// 
        /// </summary>
        public void DisplayMenu()
        {
            ConsoleHelper.OutputHeading("      Andrew's News Feed");

            string[] choices = new string[]
            {
                "Post Message", "Post Image", "" +
                "Display All Posts", "Quit"
            };

            bool wantToQuit = false;
            do
            {
                int choice = ConsoleHelper.SelectChoice(choices);

                switch (choice)
                {
                    case 1: PostMessage(); break;
                    case 2: PostImage(); break;
                    case 3: DisplayAll(); break;
                    case 4: wantToQuit = true; break;
                }    
            } while (!wantToQuit);

        }

        /// <summary>
        /// 
        /// </summary>
        private void DisplayAll()
        {
            news.Display();
        }

        /// <summary>
        /// 
        /// </summary>
        private void PostImage()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        private void PostMessage()
        {
            throw new NotImplementedException();
        }
    }
}
