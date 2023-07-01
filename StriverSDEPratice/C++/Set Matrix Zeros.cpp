class Solution {
public:
    void setZeroes(vector<vector<int>>& matrix) {
        int rows = matrix.size(), cols = matrix[0].size();
        int ind;
        for(int i=0; i<rows; i++){
            for(int j=0; j<cols; j++)
            {
                if(matrix[i][j] == 0){
                    ind = 0;
                    while(ind < rows){
                        if(matrix[i][ind]!= 0){
                            matrix[i][ind] = -1;
                        }
                        ind++;
                    }
                    ind = 0;
                    while(ind < cols){
                        if(matrix[ind][i]!= 0){
                            matrix[ind][i] = -1;
                        }
                        ind++;
                    }
                }
            }
        }
        std::cout << "Hello";
    }
};
