using System;
using System.Linq;
using System.Security.AccessControl;

namespace Pong;

public class pongHandler
{
    //define variables
    private string fieldTile;
    private string line;
    private string racketTile;
    private string ballTile;

    private int fieldLength, fieldWidth;
    private int racketLength;
    private int leftRacketHeight;
    private int rightRacketHeight;
    private int ballX;
    private int ballY;
    private int leftPlayerPoints;
    private int rightPlayerPoints;
    private int scoreboardX;
    private int scoreboardY;

    private bool isBallGoingDown;
    private bool isBallGoingRight;

    public pongHandler() 
    {
        //Consructor to initialise variables

        fieldLength = 50; 
        fieldWidth = 15;
        fieldTile = "#";
        line = string.Concat(Enumerable.Repeat(fieldTile, fieldLength));
        racketLength = fieldWidth / 4;
        racketTile = "|";
        leftRacketHeight = 0;
        rightRacketHeight = 0;
        ballX = fieldLength / 2;
        ballY = fieldWidth / 2;
        ballTile = "O";
        isBallGoingDown = true;
        isBallGoingRight = true;
        leftPlayerPoints = 0;
        rightPlayerPoints = 0;
        scoreboardX = fieldLength / 2 - 2;
        scoreboardY = fieldWidth + 3;
    }

    public void playPong()
    {
        Console.Clear();

        while (true)
        {
            //hide the cursor
            Console.CursorVisible = false;
            //move the cursor to the top left corner and print a "line"
            Console.SetCursorPosition(0, 0);
            Console.WriteLine(line);
            //move the cursor to another position and print another "line"
            Console.SetCursorPosition(0, fieldWidth);
            Console.WriteLine(line);

            for (int i = 0; i < racketLength; i++)
            {
                //print the racket that the player will use to deflect the ball
                Console.SetCursorPosition(0, i + 1 + leftRacketHeight);
                Console.WriteLine(racketTile);
                Console.SetCursorPosition(fieldLength - 1, i + 1 + rightRacketHeight);
                Console.WriteLine(racketTile);
            }

            while(!Console.KeyAvailable)
            {
                Console.SetCursorPosition(ballX, ballY);
                Console.WriteLine(ballTile);
                Thread.Sleep(100);

                Console.SetCursorPosition(ballX, ballY);
                Console.WriteLine(' ');

                if(isBallGoingDown)
                {
                    ballY++;
                }
                else
                {
                    ballY--;
                }
                if(isBallGoingRight)
                {
                    ballX++;
                }
                else
                {
                    ballX--;
                }

                if(ballY == 1 || ballY == fieldWidth - 1)
                {
                    isBallGoingDown = !isBallGoingDown;
                }

                if(ballX  == 1)
                {
                    if(ballY >= leftRacketHeight + 1 && ballY <= leftRacketHeight + racketLength)
                    {
                        isBallGoingRight = !isBallGoingRight;
                    }
                    else
                    {
                        rightPlayerPoints++;
                        ballY = fieldWidth / 2;
                        ballX = fieldLength / 2;
                        Console.SetCursorPosition(scoreboardX, scoreboardY);
                        Console.WriteLine($"{leftPlayerPoints} | {rightPlayerPoints}");

                        if(rightPlayerPoints == 11)
                        {
                            goto outer;
                        }
                    }
                }
                if (ballX == fieldLength - 2)
                {
                    if (ballY >= rightRacketHeight + 1 && ballY <= rightRacketHeight + racketLength)
                    {
                        isBallGoingRight = !isBallGoingRight;
                    }
                    else
                    {
                        leftPlayerPoints++;
                        ballY = fieldWidth / 2;
                        ballX = fieldLength / 2;
                        Console.SetCursorPosition(scoreboardX, scoreboardY);
                        Console.WriteLine($"{leftPlayerPoints} | {rightPlayerPoints}");

                        if (leftPlayerPoints == 11)
                        {
                            displayWinner();
                        }
                    }
                }

            }

            switch(Console.ReadKey().Key)
            {
                //if one of the players presses the up, down, W or S keys than
                //change the corresponding height of the racket

                case ConsoleKey.UpArrow:
                    if(rightRacketHeight > 0)
                    {
                        rightRacketHeight--;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (rightRacketHeight < fieldWidth - racketLength - 1)
                    {
                        rightRacketHeight++;
                    }
                    break;
                case ConsoleKey.W:
                    if (leftRacketHeight > 0)
                    {
                        leftRacketHeight--;
                    }
                    break;
                case ConsoleKey.S:
                    if (leftRacketHeight < fieldWidth - racketLength - 1)
                    {
                        leftRacketHeight++;
                    }
                    break;
            }
            for (int i = 1; i < fieldWidth; i++)
            {
                //print empty space betwee the two walls.
                Console.SetCursorPosition(0, i);
                Console.WriteLine(" ");
                Console.SetCursorPosition(fieldLength - 1, i);
                Console.WriteLine(" ");
            }
        }
    }
    public void displayWinner()
    {
        //empty the console
        Console.Clear();
        //place the cursor position to the top left corner
        Console.SetCursorPosition(0, 0);
        //display a message at the position of the cursor
        if (rightPlayerPoints > 10)
        {
            Console.WriteLine("Right player won!");
        }
        else
        {
            Console.WriteLine("Left player won!");
        }
    }
}