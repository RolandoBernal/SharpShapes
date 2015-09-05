﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using System.Collections.Generic;
using System.Reflection;

namespace UnitTestShapes
{
    [TestClass]
    public class ShapeTest
    {
        public class ConcreteShape : Shapes.Shape
        {
            public ConcreteShape()
            {
                BorderColor = Color.NavajoWhite;
                FillColor = Color.PapayaWhip;
            }

        }

        [TestMethod]
        public void TestAbstractShapeHasBoderColor()
        {
            ConcreteShape cs = new ConcreteShape();
            Assert.AreEqual(Color.NavajoWhite, cs.BorderColor);
        }

        [TestMethod]
        public void TestAbstractShapeHasFillColor()
        {
            ConcreteShape cs = new ConcreteShape();
            Assert.AreEqual(Color.PapayaWhip, cs.FillColor);
        }

        [TestMethod]
        [ExpectedException(typeof(NotImplementedException))]
        public void TestAbsctractShapeHasArea()
        {
            ConcreteShape cs = new ConcreteShape();
            cs.Area();
        }

        [TestMethod]
        [ExpectedException(typeof(NotImplementedException))]
        public void TestAbsctractShapeHasPerimeter()
        {
            ConcreteShape cs = new ConcreteShape();
            cs.Perimeter();
        }

        [TestMethod]
        public void FindShapesTest()
        {
            List<string> classes = new List<string> { "Square","Rectangle", "Shape" };
            CollectionAssert.AreEqual(classes, Assembly.GetAssembly(typeof(Shapes.Shape)).GetTypes());
        }

        [TestMethod]
        public void TestSquareIsASubclassOfRectangle()
        {
            Assert.IsTrue(typeof(Shapes.Square).IsSubclassOf(typeof(Shapes.Rectangle)));
        }

        [TestMethod]
        public void TestSquareIsASubclassOfQuadrilateral()
        {
            Assert.IsTrue(typeof(Shapes.Square).IsSubclassOf(typeof(Shapes.Rectangle)));
        }
    }
}
