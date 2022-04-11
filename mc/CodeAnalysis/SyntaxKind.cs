namespace Minsk.CodeAnalysis {
	public enum SyntaxKind {
		NumberToken,
		WhitespaceToken,
		PlusToken,
		MinusToken,
		StarToken,
		SlashToken,
		OpenParenthesisToken,
		CloseParenthesisToken,
		BadToken,
		EndOfFileToken,
		NumberExpression,
		BinaryExpression,
		ParenthesizedExpression,
		LiteralExpression
	}
}