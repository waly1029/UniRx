using UnityEngine;
using System.Collections;
using UniRx;
using UnityEngine.UI;

public class UinRx : MonoBehaviour {
	Subject<int>subject = new Subject<int>();
	public Button button;

	void Start(){
		button.onClick.AsObservable( ).Take( 40 )
			.Select( x => 1 )
			.Scan( 0, (element, acc ) => element + acc )
			.Where( x => ( x % 3 == 0 || x % 5 == 0 ) )
			.Subscribe( x => Debug.Log( x + " + hoge" ) );
		
		button.onClick.AsObservable( ).Take( 40 )
			.Select( x => 1 )
			.Scan( 0, (element, acc ) => element + acc )
			.Where( x => ( x % 3 != 0 && x % 5 != 0 ) )
			.Subscribe( x => Debug.Log( x ) );
	}
		
}
