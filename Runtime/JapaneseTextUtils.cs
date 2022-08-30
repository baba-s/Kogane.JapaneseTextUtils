namespace Kogane
{
    /// <summary>
    /// 日本語のテキストに関する汎用的な機能を管理するクラス
    /// </summary>
    public static class JapaneseTextUtils
    {
        //================================================================================
        // 定数
        //================================================================================
        private const string HIRAGANA = "あいうえおかきくけこさしすせそたちつてとなにぬねのはひふへほまみむめもやゆよらりるれろわをんがぎぐげござじずぜぞだぢづでどばびぶべぼぱぴぷぺぽぁぃぅぇぉっゃゅょゔ";
        private const string KATAKANA = "アイウエオカキクケコサシスセソタチツテトナニヌネノハヒフヘホマミムメモヤユヨラリルレロワヲンガギグゲゴザジズゼゾダヂヅデドバビブベボパピプペポァィゥェォッャュョヴ";

        //================================================================================
        // 関数(static)
        //================================================================================
        /// <summary>
        /// 指定されたインデックスに紐づくひらがなを返します
        /// </summary>
        public static string ToHiraganaFromIndex( int index )
        {
            return index < 0 || HIRAGANA.Length <= index
                    ? string.Empty
                    : HIRAGANA[ index ].ToString()
                ;
        }

        /// <summary>
        /// 指定された番号に紐づくひらがなを返します
        /// </summary>
        public static string ToHiraganaFromNumber( int number )
        {
            return ToHiraganaFromIndex( number - 1 );
        }

        /// <summary>
        /// 指定されたインデックスに紐づくカタカナを返します
        /// </summary>
        public static string ToKatakanaFromIndex( int index )
        {
            return index < 0 || KATAKANA.Length <= index
                    ? string.Empty
                    : KATAKANA[ index ].ToString()
                ;
        }

        /// <summary>
        /// 指定された番号に紐づくカタカナを返します
        /// </summary>
        public static string ToKatakanaFromNumber( int number )
        {
            return ToKatakanaFromIndex( number - 1 );
        }
    }
}