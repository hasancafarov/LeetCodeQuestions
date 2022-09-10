class Interval
{
    public readonly int Start;
    public readonly int End;
    
    public Interval(int start, int end)
    {
        Start = start;
        End = end;
    }
}

public class Solution 
{
    public int[][] Merge(int[][] input) 
    {
        if(input == null || input.GetLength(0) <= 1)
        {
            return input;
        }
        
        List<Interval> intervals = new List<Interval>();
        List<int[]> result = new List<int[]>();
        
        for(int i = 0; i < input.GetLength(0); i++)
        {
            intervals.Add(new Interval(input[i][0], input[i][1]));
        }
        
        intervals = intervals.OrderBy(x => x.Start).ThenBy(x => x.End).ToList();
        
        int start = 0;
        int end = 0;        
        int j = 0;
        
        while(j < intervals.Count)
        {
            start = intervals[j].Start;
            end = intervals[j].End;
            j++;
            
            while(j < intervals.Count && intervals[j].Start <= end)
            {
                end = Math.Max(end, intervals[j].End);   
                j++;
            }       
            result.Add(new int[] { start, end});           
        }                
        return result.ToArray();
    }
}