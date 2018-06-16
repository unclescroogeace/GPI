using Draw.src.Model;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace Draw
{
	public class DialogProcessor : DisplayProcessor
	{
		#region Constructor
		
		public DialogProcessor()
		{
		}

        #endregion

        #region Properties
        
        private List<Shape> selection = new List<Shape>();
		public List<Shape> Selection {
			get { return selection; }
			set { selection = value; }
		}
		
		private bool isDragging;
		public bool IsDragging {
			get { return isDragging; }
			set { isDragging = value; }
		}

		private PointF lastLocation;
		public PointF LastLocation {
			get { return lastLocation; }
			set { lastLocation = value; }
		}
		
		#endregion
		
		public void AddRandomRectangle()
		{
			Random rnd = new Random();
			int x = rnd.Next(100,1000);
			int y = rnd.Next(100,600);
			
			RectangleShape rect = new RectangleShape(new Rectangle(x,y,100,200));
			rect.FillColor = Color.White;
            rect.BorderColor = Color.Black;
            rect.Opacity = 255;

            ShapeList.Add(rect);
		}
		
		public Shape ContainsPoint(PointF point)
		{
			for(int i = ShapeList.Count - 1; i >= 0; i--){
				if (ShapeList[i].Contains(point)){
					return ShapeList[i];
				}	
			}
			return null;
		}

        public void TranslateTo(PointF p)
        {
            foreach (var item in Selection)
            {
                item.Move(p.X - lastLocation.X, p.Y - lastLocation.Y);
            }
            lastLocation = p;
        }

        public void AddRandomEllipse()
        {
            Random rnd = new Random();
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 600);

            EllipseShape ellipse = new EllipseShape(new Rectangle(x, y, 200, 100));
            ellipse.FillColor = Color.White;
            ellipse.BorderColor = Color.Black;
            ellipse.Opacity = 255;

            ShapeList.Add(ellipse);
        }

        public void AddRandomTriangle()
        {
            Random rnd = new Random();
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 600);

            TriangleShape triangle = new TriangleShape(new Rectangle(x, y, 100, 200));
            triangle.FillColor = Color.White;
            triangle.BorderColor = Color.Black;
            triangle.Opacity = 255;

            ShapeList.Add(triangle);
        }
        
        public override void Draw(Graphics grfx)
        {
            base.Draw(grfx);
            foreach (var item in Selection)
            {
                grfx.DrawRectangle(Pens.Black, item.Rectangle.Left - 3, item.Rectangle.Top - 3, item.Rectangle.Width + 6, item.Rectangle.Height + 6);
            }
        }

        public void SetFillColor(Color color)
        {
            foreach (var item in Selection)
            {
                item.FillColor = color;
            }
        }

        public void SetBorderColor(Color color)
        {
            foreach (var item in Selection)
            {
                item.BorderColor = color;
            }
        }

        public void GroupSelected()
        {
            if (Selection.Count < 2) return;

            float minX = float.PositiveInfinity;
            float minY = float.PositiveInfinity;
            float maxX = float.NegativeInfinity;
            float maxY = float.NegativeInfinity;
            foreach (var item in Selection)
            {
                if (minX > item.Location.X)
                {
                    minX = item.Location.X;
                }
                if (minY > item.Location.Y)
                {
                    minY = item.Location.Y;
                }
                if (maxX < item.Location.X + item.Width)
                {
                    maxX = item.Location.X + item.Width;
                }
                if (maxY < item.Location.Y + item.Height)
                {
                    maxY = item.Location.Y + item.Height;
                }
            }
            var group = new GroupShape(new RectangleF(minX, minY, maxX - minX, maxY - minY));
            group.SubItems = Selection;
            foreach (var item in Selection)
            {
                ShapeList.Remove(item);
            }

            Selection = new List<Shape>();
            Selection.Add(group);
            ShapeList.Add(group);

        }

        public void UnGroup()
        {
            for (int i = 0; i < Selection.Count; i++)
            {
                if (Selection[i].GetType().Equals(typeof(GroupShape)))
                {
                    GroupShape group = (GroupShape)Selection[i];
                    ShapeList.AddRange(group.SubItems);
                    group.SubItems.Clear();
                    ShapeList.Remove(group);
                    Selection[i] = null;
                    group = null;
                    ShapeList.Remove(Selection[i]);
                    Selection.Remove(Selection[i]);
                }
            }
            Selection = new List<Shape>();
        }

        internal void SetOpacity(int opacity)
        {
            
            foreach (var item in Selection)
            {
                item.GroupOpacity(opacity);
                item.Opacity = opacity;

            }
        }
    }
}