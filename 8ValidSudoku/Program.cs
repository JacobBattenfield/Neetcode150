using System.Runtime.InteropServices;

class Program{
    static void Main(){
        bool Board1 = ValidSudoku([         ['1','2','.','.','3','.','.','.','.'],
                                            ['4','.','.','5','.','.','.','.','.'],
                                            ['.','9','8','.','.','.','.','.','3'],
                                            ['5','.','.','.','6','.','.','.','4'],
                                            ['.','.','.','8','.','3','.','.','5'],
                                            ['7','.','.','.','2','.','.','.','6'],
                                            ['.','.','.','.','.','.','2','.','.'],
                                            ['.','.','.','4','1','9','.','.','8'],
                                            ['.','.','.','.','8','.','.','7','9'] ]);
                Console.WriteLine(Board1);
        bool Board2 = ValidSudoku([         ['1','2','.','.','3','.','.','.','.'],
                                            ['4','.','.','5','.','.','.','.','.'],
                                            ['.','9','1','.','.','.','.','.','3'],
                                            ['5','.','.','.','6','.','.','.','4'],
                                            ['.','.','.','8','.','3','.','.','5'],
                                            ['7','.','.','.','2','.','.','.','6'],
                                            ['.','.','.','.','.','.','2','.','.'],
                                            ['.','.','.','4','1','9','.','.','8'],
                                            ['.','.','.','.','8','.','.','7','9'] ]);
                Console.WriteLine(Board2);

    }
    static bool ValidSudoku(char[][] board){
        
        foreach(char[] row in board){
            HashSet<char> SeenInRow = [];
            foreach(char c in row){
                if(c!='.'&&SeenInRow.Contains(c)){
                    return false;
                }
                SeenInRow.Add(c);
            }
        }
        for(int i = 0;i<9;i++){
            HashSet<char> SeenInColumn = [];
            for(int j = 0;j<0;j++){
                char c = board[j][i];
                if(c!='.'&&SeenInColumn.Contains(c)){
                    return false;
                }
                SeenInColumn.Add(c);
            }
        }
        for(int square = 0;square<9;square++){
            HashSet<char> SeenInSquare = [];
            for(int i = 0;i<3;i++){
                for(int j = 0;j<3;j++){
                    int row = (square/3)*3+i;
                    int col = (square%3)*3+j;
                    if(board[row][col]!='.'&&SeenInSquare.Contains(board[row][col])){
                        return false;
                    }
                    SeenInSquare.Add(board[row][col]);
                }
            }
        }
        return true;
    }
}
