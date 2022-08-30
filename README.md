# Kogane Japanese Text Utils

日本語のテキストに関する汎用的な機能を管理するクラス

```csharp
using Kogane;
using UnityEngine;

public class Example : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log( JapaneseTextUtils.ToHiraganaFromIndex( 0 ) ); // あ
        Debug.Log( JapaneseTextUtils.ToHiraganaFromIndex( 1 ) ); // い
        Debug.Log( JapaneseTextUtils.ToHiraganaFromIndex( 2 ) ); // う
        Debug.Log( JapaneseTextUtils.ToHiraganaFromIndex( 3 ) ); // え
        Debug.Log( JapaneseTextUtils.ToHiraganaFromIndex( 4 ) ); // お

        Debug.Log( JapaneseTextUtils.ToHiraganaFromNumber( 1 ) ); // あ
        Debug.Log( JapaneseTextUtils.ToHiraganaFromNumber( 2 ) ); // い
        Debug.Log( JapaneseTextUtils.ToHiraganaFromNumber( 3 ) ); // う
        Debug.Log( JapaneseTextUtils.ToHiraganaFromNumber( 4 ) ); // え
        Debug.Log( JapaneseTextUtils.ToHiraganaFromNumber( 5 ) ); // お

        Debug.Log( JapaneseTextUtils.ToKatakanaFromIndex( 0 ) ); // ア
        Debug.Log( JapaneseTextUtils.ToKatakanaFromIndex( 1 ) ); // イ
        Debug.Log( JapaneseTextUtils.ToKatakanaFromIndex( 2 ) ); // ウ
        Debug.Log( JapaneseTextUtils.ToKatakanaFromIndex( 3 ) ); // エ
        Debug.Log( JapaneseTextUtils.ToKatakanaFromIndex( 4 ) ); // オ

        Debug.Log( JapaneseTextUtils.ToKatakanaFromNumber( 1 ) ); // ア
        Debug.Log( JapaneseTextUtils.ToKatakanaFromNumber( 2 ) ); // イ
        Debug.Log( JapaneseTextUtils.ToKatakanaFromNumber( 3 ) ); // ウ
        Debug.Log( JapaneseTextUtils.ToKatakanaFromNumber( 4 ) ); // エ
        Debug.Log( JapaneseTextUtils.ToKatakanaFromNumber( 5 ) ); // オ
    }
}
```