//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9.3
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\Stephen\source\repos\BASICLanguageParser\BASICLanguageParser.Grammar\TestBasic.g4 by ANTLR 4.9.3

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace BASICLanguageParser {

using Antlr4.Runtime.Misc;
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="ITestBasicListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.3")]
[System.Diagnostics.DebuggerNonUserCode]
[System.CLSCompliant(false)]
public partial class TestBasicBaseListener : ITestBasicListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="TestBasicParser.prog"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterProg([NotNull] TestBasicParser.ProgContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TestBasicParser.prog"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitProg([NotNull] TestBasicParser.ProgContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TestBasicParser.line"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLine([NotNull] TestBasicParser.LineContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TestBasicParser.line"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLine([NotNull] TestBasicParser.LineContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TestBasicParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStatement([NotNull] TestBasicParser.StatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TestBasicParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStatement([NotNull] TestBasicParser.StatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TestBasicParser.gotostmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGotostmt([NotNull] TestBasicParser.GotostmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TestBasicParser.gotostmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGotostmt([NotNull] TestBasicParser.GotostmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TestBasicParser.gosubstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGosubstmt([NotNull] TestBasicParser.GosubstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TestBasicParser.gosubstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGosubstmt([NotNull] TestBasicParser.GosubstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TestBasicParser.letstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLetstmt([NotNull] TestBasicParser.LetstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TestBasicParser.letstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLetstmt([NotNull] TestBasicParser.LetstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TestBasicParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpression([NotNull] TestBasicParser.ExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TestBasicParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpression([NotNull] TestBasicParser.ExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TestBasicParser.characterExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCharacterExpression([NotNull] TestBasicParser.CharacterExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TestBasicParser.characterExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCharacterExpression([NotNull] TestBasicParser.CharacterExpressionContext context) { }

	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void EnterEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void ExitEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitTerminal([NotNull] ITerminalNode node) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitErrorNode([NotNull] IErrorNode node) { }
}
} // namespace BASICLanguageParser
