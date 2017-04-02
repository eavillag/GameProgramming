using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeldaSimulator.Classes.Entities;
using ZeldaSimulator.Controllers;

namespace ZeldaSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            ControllerGame controller_game = new ControllerGame();
            if (ControllerGame.Controller_session_count > 0){
                //read from sessions file and show session to choose from.
                //show options to delete,load or create new session.
                //show session' information.
                //get the chosen session and start the game where it left off.
                //or start new session.
            }
            else {
                //read all file and load all STLs
                //save session in the sessions directory

                //start the game from the newly created session
                //set avatar information
                //set game level information for the session.
            }

        }
    }
}
