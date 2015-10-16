#pragma strict

//Private Variables
private var InventoryOn = false;
private var scrollBarChopGrid : Vector2 = Vector2.zero;
private var GridValue : float = -1;
//GUI Pos/Size
var ClosePosition : Vector2 = new Vector2(312,5);
var CloseSize : Vector2 = new Vector2(35,35);
var GridPosition : Vector2 = new Vector2(10,2);
var GridSize : Vector2 = new Vector2(323,410);
var ScrollPosition : Vector2 = new Vector2(0,95);
var ScrollSize : Vector2 = new Vector2(353,257);
var WindowPosition : Vector2 = new Vector2(0,0);
var WindowSize : Vector2 = new Vector2(360,360);
//Textures
var InventoryWindow : Texture;
var CloseIcon : Texture;
var Grids : Texture[];

	//On or Off
	if (Input.GetKeyDown("p"))
	{
		if (InventoryOn == false)
		{
			InventoryOn = true;
		}
		else if (InventoryOn == true)
		{
			InventoryOn = false;
		}
	}
function OnGUI()
{
	if (InventoryOn == true)
	{
		GUI.BeginGroup(new Rect(WindowPosition.x, WindowPosition.y, WindowSize.x, WindowSize.y), InventoryWindow);
		//Close Button
		if (GUI.Button(Rect(40, 40, 40, 40), CloseIcon))
		{
			InventoryOn = false;
		}
		//Scroll Bar
		scrollBarChopGrid = GUI.BeginScrollView(Rect (ScrollPosition.x, ScrollPosition.y, ScrollSize.x, ScrollSize.y), scrollBarChopGrid, Rect(0,0,0,420));
			// Grid
			GridValue = GUI.SelectionGrid(Rect(GridPosition.x, GridPosition.y, GridSize.x, GridSize.y), GridValue, Grids, 5);
		GUI.EndScrollView();
		GUI.EndGroup();
	}
}

