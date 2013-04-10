// Interfaces-In-Managed-C++.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace System;

public interface class IGeometry {
	property String^ Name;
	void display();
};

public ref class CRound : public IGeometry {
private:
	String ^ name;

public:
	CRound() {
		name = "Unknown";
	}

	CRound(String^ _name) {
		name = _name;
	}

	property String^ Name {
		virtual void set(String^ value) { name = value; }
		virtual String^ get() { return name; }
	}

	virtual void display() {
		Console::WriteLine("Name: {0}", Name);
	}
};

public ref class CCircle : public CRound {
private:
	double rad;

public:
	property double Radius {
		virtual void set(double radius) { rad = radius; }
		virtual double get() { return rad; }
	}

	CCircle(String ^name, double r) {
		Name = name;
		rad = r;
	}

	virtual double Area() {
		return Radius * Radius * 3.14;
	}

	virtual void display() new { 
		Console::WriteLine("Name: {0}", Name);
		Console::WriteLine("Radius: {0}", Radius);
		Console::WriteLine("Area: {0}", Area());
	}
};

int _tmain(int argc, _TCHAR* argv[])
{
	CCircle^ circle = gcnew CCircle("Circle", 4);
	circle->display();
	return 0;
}

