using UnityEngine;
using Mapbox.Map;
using Mapbox.Unity;
using Mapbox.Utils;

public class RasterMap : MonoBehaviour, Mapbox.Utils.IObserver<RasterTile>
{
	void Start()
	{
		var map = new Map<RasterTile>(MapboxAccess.Instance);
		map.Zoom = 2;
		map.Vector2dBounds = Vector2dBounds.World();
		map.MapId = "mapbox://styles/miker256/cj5w36k7r72ev2sr1c1mpnyii";
		map.Subscribe(this);
		map.Update();
	}

	public void OnNext(RasterTile tile)
	{
		if (tile.CurrentState == Tile.State.Loaded)
		{
			if (tile.HasError)
			{
				Debug.Log("RasterMap: " + tile.ExceptionsAsString);
				return;
			}

			var tileQuad = GameObject.CreatePrimitive(PrimitiveType.Quad);
			tileQuad.transform.SetParent(transform);
			tileQuad.name = tile.Id.ToString();
			tileQuad.transform.position = new Vector3(tile.Id.X, -tile.Id.Y, 0);
			var texture = new Texture2D(0, 0);
			texture.LoadImage(tile.Data);
			var material = new Material(Shader.Find("Unlit/Texture"));
			material.mainTexture = texture;
			tileQuad.GetComponent<MeshRenderer>().sharedMaterial = material;
		}
	}
}