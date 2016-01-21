// Decompiled with JetBrains decompiler
// Type: System.Linq.Expressions.NewExpression
// Assembly: System.Core, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e, Retargetable=Yes
// MVID: 388EE07E-2A8E-46A3-8A40-DFB10FCDA183
// Assembly location: C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETPortable\v4.0\Profile\Profile136\System.Core.dll

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;
using System;

namespace System.Linq.Expressions
{
	public class NewExpression : Expression
	{
		internal NewExpression(ExpressionType nodeType)
			: base(nodeType)
        {
        }
		public ReadOnlyCollection<Expression> Arguments
		{
			get
			{
				return (ReadOnlyCollection<Expression>)null;
			}
		}

		public ConstructorInfo Constructor
		{
			get
			{
				return (ConstructorInfo)null;
			}
		}

		public ReadOnlyCollection<MemberInfo> Members
		{
			get
			{
				return (ReadOnlyCollection<MemberInfo>)null;
			}
		}

		

		//public override System.Type Type
		//{
		//    get
		//    {
		//        return (System.Type)null;
		//    }get
		//    {
		//        return ExpressionType.Add;
		//    }
		//}

		//protected internal override Expression Accept(ExpressionVisitor visitor)
		//{
		//    return (Expression)null;
		//}

		public NewExpression Update(IEnumerable<Expression> arguments)
		{
			return (NewExpression)null;
		}
	}
	

	public abstract class ExpressionVisitor
	{
		public ReadOnlyCollection<Expression> Visit(ReadOnlyCollection<Expression> nodes)
		{
			return (ReadOnlyCollection<Expression>)null;
		}

		public virtual Expression Visit(Expression node)
		{
			return (Expression)null;
		}

		public static ReadOnlyCollection<T> Visit<T>(ReadOnlyCollection<T> nodes, Func<T, T> elementVisitor)
		{
			return (ReadOnlyCollection<T>)null;
		}

		public T VisitAndConvert<T>(T node, string callerName) where T : Expression
		{
			return default(T);
		}

		public ReadOnlyCollection<T> VisitAndConvert<T>(ReadOnlyCollection<T> nodes, string callerName) where T : Expression
		{
			return (ReadOnlyCollection<T>)null;
		}

		//protected internal virtual Expression VisitBinary(BinaryExpression node)
		//{
		//    return (Expression)null;
		//}

		//protected internal virtual Expression VisitBlock(BlockExpression node)
		//{
		//    return (Expression)null;
		//}

		protected virtual CatchBlock VisitCatchBlock(CatchBlock node)
		{
			return (CatchBlock)null;
		}

		//protected internal virtual Expression VisitConditional(ConditionalExpression node)
		//{
		//    return (Expression)null;
		//}

		protected internal virtual Expression VisitConstant(ConstantExpression node)
		{
			return (Expression)null;
		}

		//protected internal virtual Expression VisitDebugInfo(DebugInfoExpression node)
		//{
		//    return (Expression)null;
		//}

		//protected internal virtual Expression VisitDefault(DefaultExpression node)
		//{
		//    return (Expression)null;
		//}

		//protected internal virtual Expression VisitDynamic(DynamicExpression node)
		//{
		//    return (Expression)null;
		//}

		protected virtual ElementInit VisitElementInit(ElementInit node)
		{
			return (ElementInit)null;
		}

		protected internal virtual Expression VisitExtension(Expression node)
		{
			return (Expression)null;
		}

		//protected internal virtual Expression VisitGoto(GotoExpression node)
		//{
		//    return (Expression)null;
		//}

		//protected internal virtual Expression VisitIndex(IndexExpression node)
		//{
		//    return (Expression)null;
		//}

		//protected internal virtual Expression VisitInvocation(InvocationExpression node)
		//{
		//    return (Expression)null;
		//}

		//protected internal virtual Expression VisitLabel(LabelExpression node)
		//{
		//    return (Expression)null;
		//}

		protected virtual LabelTarget VisitLabelTarget(LabelTarget node)
		{
			return (LabelTarget)null;
		}

		//protected internal virtual Expression VisitLambda<T>(Expression<T> node)
		//{
		//    return (Expression)null;
		//}

		//protected internal virtual Expression VisitListInit(ListInitExpression node)
		//{
		//    return (Expression)null;
		//}

		//protected internal virtual Expression VisitLoop(LoopExpression node)
		//{
		//    return (Expression)null;
		//}

		protected internal virtual Expression VisitMember(MemberExpression node)
		{
			return (Expression)null;
		}

		protected virtual MemberAssignment VisitMemberAssignment(MemberAssignment node)
		{
			return (MemberAssignment)null;
		}

		protected virtual MemberBinding VisitMemberBinding(MemberBinding node)
		{
			return (MemberBinding)null;
		}

		//protected internal virtual Expression VisitMemberInit(MemberInitExpression node)
		//{
		//    return (Expression)null;
		//}

		protected virtual MemberListBinding VisitMemberListBinding(MemberListBinding node)
		{
			return (MemberListBinding)null;
		}

		protected virtual MemberMemberBinding VisitMemberMemberBinding(MemberMemberBinding node)
		{
			return (MemberMemberBinding)null;
		}

		protected internal virtual Expression VisitMethodCall(MethodCallExpression node)
		{
			return (Expression)null;
		}

		protected internal virtual Expression VisitNew(NewExpression node)
		{
			return (Expression)null;
		}

		//protected internal virtual Expression VisitNewArray(NewArrayExpression node)
		//{
		//    return (Expression)null;
		//}

		protected internal virtual Expression VisitParameter(ParameterExpression node)
		{
			return (Expression)null;
		}

		//protected internal virtual Expression VisitRuntimeVariables(RuntimeVariablesExpression node)
		//{
		//    return (Expression)null;
		//}

		//protected internal virtual Expression VisitSwitch(SwitchExpression node)
		//{
		//    return (Expression)null;
		//}

		protected virtual SwitchCase VisitSwitchCase(SwitchCase node)
		{
			return (SwitchCase)null;
		}

		//protected internal virtual Expression VisitTry(TryExpression node)
		//{
		//    return (Expression)null;
		//}

		//protected internal virtual Expression VisitTypeBinary(TypeBinaryExpression node)
		//{
		//    return (Expression)null;
		//}

		//protected internal virtual Expression VisitUnary(UnaryExpression node)
		//{
		//    return (Expression)null;
		//}
	}
	public sealed class CatchBlock
	{
		public Expression Body
		{
			get
			{
				return (Expression)null;
			}
		}

		public Expression Filter
		{
			get
			{
				return (Expression)null;
			}
		}

		public Type Test
		{
			get
			{
				return (Type)null;
			}
		}

		public ParameterExpression Variable
		{
			get
			{
				return (ParameterExpression)null;
			}
		}

		internal CatchBlock()
		{
		}

		public override string ToString()
		{
			return (string)null;
		}

		public CatchBlock Update(ParameterExpression variable, Expression filter, Expression body)
		{
			return (CatchBlock)null;
		}
	}
	public sealed class SwitchCase
	{
		public Expression Body
		{
			get
			{
				return (Expression)null;
			}
		}

		public ReadOnlyCollection<Expression> TestValues
		{
			get
			{
				return (ReadOnlyCollection<Expression>)null;
			}
		}

		internal SwitchCase()
		{
		}

		public override string ToString()
		{
			return (string)null;
		}

		public SwitchCase Update(IEnumerable<Expression> testValues, Expression body)
		{
			return (SwitchCase)null;
		}
	}
	public sealed class LabelTarget
	{
		public string Name
		{
			get
			{
				return (string)null;
			}
		}

		public Type Type
		{
			get
			{
				return (Type)null;
			}
		}

		internal LabelTarget()
		{
		}

		public override string ToString()
		{
			return (string)null;
		}
	}
	public sealed class ElementInit
	{
		public MethodInfo AddMethod
		{
			get
			{
				return (MethodInfo)null;
			}
		}

		public ReadOnlyCollection<Expression> Arguments
		{
			get
			{
				return (ReadOnlyCollection<Expression>)null;
			}
		}

		internal ElementInit()
		{
		}

		public override string ToString()
		{
			return (string)null;
		}

		public ElementInit Update(IEnumerable<Expression> arguments)
		{
			return (ElementInit)null;
		}
	}
	public sealed class MemberAssignment : MemberBinding
	{
		public Expression Expression
		{
			get
			{
				return (Expression)null;
			}
		}

		internal MemberAssignment()
		{
		}

		public MemberAssignment Update(Expression expression)
		{
			return (MemberAssignment)null;
		}
	}
	public enum MemberBindingType
	{
		Assignment,
		MemberBinding,
		ListBinding,
	}
	public abstract class MemberBinding
	{
		public MemberBindingType BindingType
		{
			get
			{
				return MemberBindingType.Assignment;
			}
		}

		public MemberInfo Member
		{
			get
			{
				return (MemberInfo)null;
			}
		}

		internal MemberBinding()
		{
		}

		public override string ToString()
		{
			return (string)null;
		}
	}
	public sealed class MemberListBinding : MemberBinding
	{
		public ReadOnlyCollection<ElementInit> Initializers
		{
			get
			{
				return (ReadOnlyCollection<ElementInit>)null;
			}
		}

		internal MemberListBinding()
		{
		}

		public MemberListBinding Update(IEnumerable<ElementInit> initializers)
		{
			return (MemberListBinding)null;
		}
	}
	public sealed class MemberMemberBinding : MemberBinding
	{
		public ReadOnlyCollection<MemberBinding> Bindings
		{
			get
			{
				return (ReadOnlyCollection<MemberBinding>)null;
			}
		}

		internal MemberMemberBinding()
		{
		}

		public MemberMemberBinding Update(IEnumerable<MemberBinding> bindings)
		{
			return (MemberMemberBinding)null;
		}
	}
	//public class BinaryExpression : Expression
	//{
	//    public override bool CanReduce
	//    {
	//        get
	//        {
	//            return false;
	//        }
	//    }

	//    public LambdaExpression Conversion
	//    {
	//        get
	//        {
	//            return (LambdaExpression)null;
	//        }
	//    }

	//    public bool IsLifted
	//    {
	//        get
	//        {
	//            return false;
	//        }
	//    }

	//    public bool IsLiftedToNull
	//    {
	//        get
	//        {
	//            return false;
	//        }
	//    }

	//    public Expression Left
	//    {
	//        get
	//        {
	//            return (Expression)null;
	//        }
	//    }

	//    public MethodInfo Method
	//    {
	//        get
	//        {
	//            return (MethodInfo)null;
	//        }
	//    }

	//    public Expression Right
	//    {
	//        get
	//        {
	//            return (Expression)null;
	//        }
	//    }


	//    protected internal override Expression Accept(ExpressionVisitor visitor)
	//    {
	//        return (Expression)null;
	//    }

	//    public override Expression Reduce()
	//    {
	//        return (Expression)null;
	//    }

	//    public BinaryExpression Update(Expression left, LambdaExpression conversion, Expression right)
	//    {
	//        return (BinaryExpression)null;
	//    }
	//}
	//public class BlockExpression : Expression
	//{
	//    public ReadOnlyCollection<Expression> Expressions
	//    {
	//        get
	//        {
	//            return (ReadOnlyCollection<Expression>)null;
	//        }
	//    }

	//    public override sealed ExpressionType NodeType
	//    {
	//        get
	//        {
	//            return ExpressionType.Add;
	//        }
	//    }

	//    public Expression Result
	//    {
	//        get
	//        {
	//            return (Expression)null;
	//        }
	//    }

	//    public override Type Type
	//    {
	//        get
	//        {
	//            return (Type)null;
	//        }
	//    }

	//    public ReadOnlyCollection<ParameterExpression> Variables
	//    {
	//        get
	//        {
	//            return (ReadOnlyCollection<ParameterExpression>)null;
	//        }
	//    }


	//    protected internal override Expression Accept(ExpressionVisitor visitor)
	//    {
	//        return (Expression)null;
	//    }

	//    public BlockExpression Update(IEnumerable<ParameterExpression> variables, IEnumerable<Expression> expressions)
	//    {
	//        return (BlockExpression)null;
	//    }
	//}
	//public class ConditionalExpression : Expression
	//{
	//    public Expression IfFalse
	//    {
	//        get
	//        {
	//            return (Expression)null;
	//        }
	//    }

	//    public Expression IfTrue
	//    {
	//        get
	//        {
	//            return (Expression)null;
	//        }
	//    }

	//    public override sealed ExpressionType NodeType
	//    {
	//        get
	//        {
	//            return ExpressionType.Add;
	//        }
	//    }

	//    public Expression Test
	//    {
	//        get
	//        {
	//            return (Expression)null;
	//        }
	//    }

	//    public override Type Type
	//    {
	//        get
	//        {
	//            return (Type)null;
	//        }
	//    }

	//    protected internal override Expression Accept(ExpressionVisitor visitor)
	//    {
	//        return (Expression)null;
	//    }

	//    public ConditionalExpression Update(Expression test, Expression ifTrue, Expression ifFalse)
	//    {
	//        return (ConditionalExpression)null;
	//    }
	//}
	//public class DebugInfoExpression : Expression
	//{
	//    public SymbolDocumentInfo Document
	//    {
	//        get
	//        {
	//            return (SymbolDocumentInfo)null;
	//        }
	//    }

	//    public virtual int EndColumn
	//    {
	//        get
	//        {
	//            return 0;
	//        }
	//    }

	//    public virtual int EndLine
	//    {
	//        get
	//        {
	//            return 0;
	//        }
	//    }

	//    public virtual bool IsClear
	//    {
	//        get
	//        {
	//            return false;
	//        }
	//    }

	//    public override sealed ExpressionType NodeType
	//    {
	//        get
	//        {
	//            return ExpressionType.Add;
	//        }
	//    }

	//    public virtual int StartColumn
	//    {
	//        get
	//        {
	//            return 0;
	//        }
	//    }

	//    public virtual int StartLine
	//    {
	//        get
	//        {
	//            return 0;
	//        }
	//    }

	//    public override sealed Type Type
	//    {
	//        get
	//        {
	//            return (Type)null;
	//        }
	//    }

	//    internal DebugInfoExpression()
	//    {
	//    }

	//    protected internal override Expression Accept(ExpressionVisitor visitor)
	//    {
	//        return (Expression)null;
	//    }
	//}
}