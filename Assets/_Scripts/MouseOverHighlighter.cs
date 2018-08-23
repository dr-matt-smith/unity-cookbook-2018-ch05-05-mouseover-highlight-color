using UnityEngine;

public class MouseOverHighlighter : MonoBehaviour 
{
	public Color mouseOverColor = Color.yellow;

	private Material originalMaterial;
	private Material mouseOverMaterial;
	private MeshRenderer meshRenderer;

	void Start()
	{		
		meshRenderer = GetComponent<MeshRenderer>();
		originalMaterial = meshRenderer.material;
		mouseOverMaterial = new Material(meshRenderer.sharedMaterial);
		mouseOverMaterial.color = mouseOverColor;
	}
	
	void OnMouseOver()
	{
		meshRenderer.material = mouseOverMaterial;
	}
	
	void OnMouseExit()
	{
		meshRenderer.material = originalMaterial;
	}
}
