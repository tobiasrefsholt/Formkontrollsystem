﻿using Formkontrollsystem;

var shapes = new ShapeList();
shapes.AddShape(new Circle("Big", "red", 2654));
shapes.AddShape(new Circle("Small", "red", 12));
shapes.AddShape(new Rectangle("Some house", "yellow", 30.5, 23));
shapes.AddShape(new Rectangle("Really big house", "pink", 637.5, 9001.2));
shapes.AddShape(new Triangle("Christmas Tree", "green", 3, 12));
shapes.AddShape(new Triangle("Triangle (instrument)", "green", 0.1, 0.1));
shapes.ShowAll();
shapes.ShowTotalArea();