using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace VisionRecognition
{
    public enum StepsTypes
    {
        NoMove,
        Up,
        Down,
        Left,
        Right,
        Any
    }
    
    public class PathSolver
    {
        private GridRecognizer recognizer;
        private bool[] tempBuffer;
        public PathSolver(GridRecognizer _recognizer)
        {
            recognizer = _recognizer;
            tempBuffer = new bool[_recognizer.GetBuffer().Length];
            for (int i = 0; i < _recognizer.GetBuffer().Length; i++ )
            {
                tempBuffer[i] = _recognizer.GetBuffer()[i]==true;
            }
                
        }
        public bool Silence = false;

        public PathSequence Solve()
        {
            PathSequence path = new PathSequence(); 
            try
            {
                path = Solve(recognizer.StartPoint, recognizer.FinishPoint, StepsTypes.Any);
            }
            catch
            { }

            if (Silence)
                return path;

            if (path.IsEmpty() )
                MessageBox.Show("No Solution found");
            else
                MessageBox.Show("Solution found");

            return path;
        }
        private PathSequence Solve(Point start, Point end, StepsTypes move)
        {
            System.Diagnostics.StackTrace st = new System.Diagnostics.StackTrace();
            if (st.FrameCount > 64)
                return new PathSequence();
            
            int CurrentX = start.X;
            int CurrentY = start.Y;
            int PosibleMoves = 0;

            StepsTypes[] Posibles = new StepsTypes[4];

            PathSequence sequence = new PathSequence();

            nextPosition:
            Posibles[0] = StepsTypes.NoMove;
            Posibles[1] = StepsTypes.NoMove;
            Posibles[2] = StepsTypes.NoMove;
            Posibles[3] = StepsTypes.NoMove;
            PosibleMoves = 0;

            /* This Part of algorith if for discriminate the start step of the other level of
             * recursive function */
            if (CanMoveUp(CurrentX, CurrentY) && (move != StepsTypes.Down || move == StepsTypes.Any))
            {
                PosibleMoves++;
                Posibles[0] = StepsTypes.Up;
            }

            if (CanMoveDown(CurrentX, CurrentY) && (move != StepsTypes.Up || move == StepsTypes.Any))
            {
                PosibleMoves++;
                Posibles[1] = StepsTypes.Down;
            }

            if (CanMoveLeft(CurrentX, CurrentY) && (move != StepsTypes.Right || move == StepsTypes.Any))
            {
                PosibleMoves++;
                Posibles[2] = StepsTypes.Left;
            }

            if (CanMoveRight(CurrentX, CurrentY) && (move != StepsTypes.Left || move == StepsTypes.Any))
            {
                PosibleMoves++;
                Posibles[3] = StepsTypes.Right;
            }

            if (CurrentX == recognizer.FinishPoint.X && CurrentY == recognizer.FinishPoint.Y) // Solution Found
            {
                sequence.Finished = true;
                return sequence;
            }

            if (PosibleMoves == 0)
            {
                return new PathSequence();
            }
                

            if (PosibleMoves == 1)
            {
                for(int i = 0; i<4; i++)
                {
                    if(Posibles[i] != StepsTypes.NoMove)
                    {
                        sequence.Steps.Add(new PathStep(Posibles[i], 1));
                        SetPosition(CurrentX, CurrentY, true);


                        if(Posibles[i] == StepsTypes.Up)
                            CurrentY--;
                        if(Posibles[i] == StepsTypes.Down)
                            CurrentY++;
                        if(Posibles[i] == StepsTypes.Left)
                            CurrentX--;
                        if(Posibles[i] == StepsTypes.Right)
                            CurrentX++;
                    }
                }
                move = StepsTypes.Any;
                goto nextPosition;
            }

            if (PosibleMoves >= 2)
            {
                if (CanMoveUp(CurrentX, CurrentY) && (move != StepsTypes.Up || move == StepsTypes.Any))
                {
                    PathSequence newpath = Solve(new Point(CurrentX, CurrentY-1), recognizer.FinishPoint, StepsTypes.Up);

                    if (!newpath.IsEmpty() || newpath.Finished)
                    {
                        sequence.Steps.Add(new PathStep(StepsTypes.Up, 1));
                        sequence.Combine(newpath);
                    }
                    if (newpath.Finished)
                        return sequence;
                }

                if (CanMoveDown(CurrentX, CurrentY) && (move != StepsTypes.Down || move == StepsTypes.Any))
                {
                    PathSequence newpath = Solve(new Point(CurrentX, CurrentY+1), recognizer.FinishPoint, StepsTypes.Down);
                    
                    if (!newpath.IsEmpty() || newpath.Finished)
                    {
                        sequence.Steps.Add(new PathStep(StepsTypes.Down, 1));
                        sequence.Combine(newpath);
                    }
                    if (newpath.Finished)
                        return sequence;
                }

                if (CanMoveLeft(CurrentX, CurrentY) && (move != StepsTypes.Left || move == StepsTypes.Any))
                {
                    PathSequence newpath = Solve(new Point(CurrentX-1, CurrentY), recognizer.FinishPoint, StepsTypes.Left);
                    
                    if (!newpath.IsEmpty() || newpath.Finished)
                    {
                        sequence.Steps.Add(new PathStep(StepsTypes.Left, 1));
                        sequence.Combine(newpath);
                    }
                    if (newpath.Finished)
                        return sequence;
                }

                if (CanMoveRight(CurrentX, CurrentY) && (move != StepsTypes.Right || move == StepsTypes.Any))
                {
                    PathSequence newpath = Solve(new Point(CurrentX+1, CurrentY), recognizer.FinishPoint, StepsTypes.Right);
                    
                    if (!newpath.IsEmpty() || newpath.Finished)
                    {
                        sequence.Steps.Add(new PathStep(StepsTypes.Right, 1));
                        sequence.Combine(newpath);
                    }
                    if (newpath.Finished)
                        return sequence;
                }
                move = StepsTypes.Any;
                goto nextPosition;
            }

            return null; /// Returns null if the algorith doesn't recognize other node or the end;
        }

        public bool GetPosition(int x, int y)
        {
            if (x < 0 || x >= recognizer._Columns || y < 0 || y >= recognizer._Rows)
                return true;
            else
                return tempBuffer[(y * recognizer._Columns) + x];
        }
        public void SetPosition(int x, int y, bool solid)
        {
            if (x < 0 || x >= recognizer._Columns || y < 0 || y >= recognizer._Rows)
                return;
            tempBuffer[(y * recognizer._Columns) + x] = solid;
        }

        private bool CanMoveUp(int x, int y)
        {
            return !GetPosition(x, y - 1);
        }
        private bool CanMoveDown(int x, int y)
        {
            return !GetPosition(x, y + 1);
        }
        private bool CanMoveLeft(int x, int y)
        {
            return !GetPosition(x-1, y);
        }
        private bool CanMoveRight(int x, int y)
        {
            return !GetPosition(x + 1, y);
        }
    }

    public class PathSequence
    {
        public int Distance;
        public List<PathStep> Steps;
        public bool Finished = false;

        public PathSequence()
        {
            Steps = new List<PathStep>();
        }
        public void Combine(PathSequence seq)
        {
            if (seq.Finished)
                this.Finished = true;
            foreach (PathStep step in seq.Steps)
                this.Steps.Add(step);
        }
        public bool IsEmpty()
        {
            return Steps.Count == 0;
        }
    }
    
    public class PathStep
    {
        public int Distance;
        public StepsTypes sType;
        public PathStep(StepsTypes t, int dis)
        {
            Distance = dis;
            sType = t;
        }
        public override string ToString()
        {
            return sType.ToString() + " " + Distance.ToString();
        }
    }
}
