namespace WisejHybridLocalApplication1
{
	public class GameObject
	{
		public GameObject()
		{
		}

		public GameObject(int x, int y)
		{
			X = x;
			Y = y;
		}

		public int X { get; set; }
		public int Y { get; set; }

		public bool IsSamePosition(GameObject obj) => X == obj.X && Y == obj.Y;
	}
}