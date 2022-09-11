public class Solution {
    public int[][] FloodFill(int[][] image, int sr, int sc, int color) {
        if (image[sr][sc] == color) return image;
        Flood(image,sr,sc,image[sr][sc],color);
        return image;
    }
    
    public void Flood(int[][] image,int sr,int sc,int color,int newColor){
        
        if (sr < 0 || sr >= image.Length || sc < 0 || sc >= image[0].Length || image[sr][sc] != color) return;
        
        image[sr][sc]=newColor;
        
        Flood(image,sr+1,sc,color,newColor);
        Flood(image,sr,sc+1,color,newColor);
        Flood(image,sr-1,sc,color,newColor);
        Flood(image,sr,sc-1,color,newColor);
            
    }
}