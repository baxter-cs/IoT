using System;
using System.Collections.Generic;

public class CellSearch
{

	public HashSet<Cell> CellGroup(Cell startingPoint) {
		HashSet<Cell> marked = new HashSet<Cell> ();
		CheckCellGroupFunc (startingPoint, marked);
		return marked;
	}

	private void CheckCellGroupFunc(Cell startingPoint, HashSet<Cell> marked) {

		if (marked.Contains (startingPoint)) {
			return;
		}
		marked.Add (this);
		foreach (Cell neighbor in startingPoint.neighbors) {
			CellGroup (neighbor, marked);
		}
		return;
	}
}

