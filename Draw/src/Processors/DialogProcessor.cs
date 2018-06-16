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

            ShapeList.Add(ellipse);
        }

        public void AddRandomTriangle()
        {
            Random rnd = new Random();
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 600);

            TriangleShape triangle = new TriangleShape(new Rectangle(x, y, 100, 200));
            triangle.FillColor = Color.White;

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
    }
}