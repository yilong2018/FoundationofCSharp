using System;

namespace M05L03PlanningWO
{
    class Program
    {
        static void Main(string[] args)
        {
            // W-O-U-L-D framework
            // [W]alk through the project
            // [O]pen up the true requirements
            // [U]ser interface design (2 min a sketch -> take hole 10-15 mi)
            // [L]ogic design
            // [D]ata design 

            // Try going through the first two steps of the WOULD framework on the Battleship Lite application.

            /////// 自己的想法
            // Walk through the project 
            // 一个游戏，AB两人参与，5x5的格子。
            // 游戏开始，A、B分别在25个格子中放入自己的战舰，仅自己知晓位置
            // A选择一个位置开火，如果位置中有B战舰，B损失一艘战舰。然后轮换到B，B开火。交替开火
            // 直到某一方战舰完全损失掉。剩余战舰的一方获胜。

            // [O]pen up the true requirements
            // 不知道要说什么...

            /////// The corey W & O
            // [W]alk through the project
            // **General Flow
            // *Two users open up the console. 
            // *Ask user 1 for where to place their ships 
            // *Ask user 2 for where to place their ships
            // *Ask user 1 for a shot: determin hit or miss; determine if the game is over.
            // *Ask user 2 for a shot: determin hit or miss; determine if the game is over.
            // *Repeat until someone wins.
            // *Identify who the winner is.
            // *Exit the application.

            // [O]pen up the true requirements
            // **ADDITIONAL QUESTIONS /REQUIREMENTS
            // 1. is is the same console or two different console working together? Same console
            // 2. Does the other player get one last chance after being sunk? NO
            // 3. Do we want to capture/display statistics such as hit/miss ratio, etc.? Just how many shots it took to win
            // 4. Only one ship per spot.
            // 5. Do we allow a plyer to shoot the same spot twice? No.
            // 6. Do we show a visul of the gride? Yes
            // 7. Do we store game data? No.
            // 8. Are we never going to change the number of players? Maybe
            // 9. Will we add a computer player? Maybe
            //
            // [W] & [O]: Full Requirements
            // 1. 2-player game
            // 2. 25 spot grid [A1 - E5]
            // 3. Each palyer gets 5 ship
            // 4. Each ship takes up one spot
            // 5. Plyaers take turns firing
            // 6. First person to sink all 5 wins
            // 7. One console for everyone.
            // 8. No completing the roud after 5 sunk ships
            // 9. Show a visual of the grid with hits and misses
            // 10. Do not allow the user to shoot the same spot twice


            //// Home work: try finishing up the planning phase (U, L, and D) on your 
            //// own before we do it together in the next video.
            // [U]ser interface design (2 min a sketch -> take hole 10-15 mi)
            // A1 A2 A3 A4 A5
            // B1 B2 B3 B4 B5
            // C1 C2 C3 C4 C5
            // D1 D2 D3 D4 D5
            // E1 E2 E3 E4 E5

            // [L]ogic design
            // A、B两个用户，分别输入用户名。
            // A、B两个用户分别输入5个ship的位置，如果位置不是既定的字符，提示重新输入。如果有相同的字符，提示重新输入。直到输入符合要求
            // A开火，判断A打过这个位置没有，如果打过提示A重新段地方，
            //          如果没有打过，判断B有没有ship在同样位置，
            //          如果有，B战舰损失一艘，查看B还有没有战舰，没有宣布A胜利。
            //          并将A开过的炮弹数+1。打印A和B分别开过的炮弹数量
            //          如果没有跳过
            // B开火，判断A有没有ship在同样的位置，...


            // [D]ata design 
            // PlayerModel: UserName, Ship, FireAmount, FiredPosition
            // ShipModel: Position, IsSunked, 


            Console.ReadLine();
        }
    }
}
