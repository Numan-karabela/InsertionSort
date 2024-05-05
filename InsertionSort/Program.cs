

int[] number = [1, 0, 5, 4, 8, 2, 6, 3, 7, 9];

 InsortionSort(number);
void InsortionSort<T>(T[] array) where T : IComparable
{
	for (int i = 1; i < array.Length; i++)
	{
		T key = array[i];
		int j = 1 - i;

		while (j > 0&& array[j].CompareTo(key)>0)
		{
			array[j+1]= array[j];
			j--;

		}
		array[j+1] = key;

	}


}