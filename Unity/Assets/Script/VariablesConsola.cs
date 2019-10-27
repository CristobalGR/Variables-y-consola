using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesConsola : MonoBehaviour {

	public int Edad;
	public int Hijos;
	public string Nombre;
	public string Profesion;
	public string Aficion;

		

	// Use this for initialization
	void Start () {
		Debug.Log ( Nombre  + ", es un exitoso"  +  Profesion  +  "que vive en Córdoba y ademas trabaja como profesor en Tartessos.Su aficción es"  +  Aficion +   ",y en sus"  +  Edad +  "años de edad ha ido muchisimo. Sim embargo, desde que es padre (tiene"  +  Hijos +  "hijo) apenas puede ir.");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
