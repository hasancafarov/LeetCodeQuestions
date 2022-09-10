public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        IList<IList<int>> res = new List<IList<int>>();
		List<int> row, pre = null;
		for (int i = 0; i < numRows; ++i) {
			row = new List<int>();
			for (int j = 0; j <= i; ++j)
				if (j == 0 || j == i)
					row.Add(1);
				else
					row.Add(pre[j - 1] + pre[j]);
			pre = row;
			res.Add(row);
		}
		return res;
    }
}