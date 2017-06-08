/*
 * @(#)RegTestExpressionAPI.cs        4.1.0    2017-05-28
 *
 * You may use this software under the condition of "Simplified BSD License"
 *
 * Copyright 2010-2017 MARIUSZ GROMADA. All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without modification, are
 * permitted provided that the following conditions are met:
 *
 *    1. Redistributions of source code must retain the above copyright notice, this list of
 *       conditions and the following disclaimer.
 *
 *    2. Redistributions in binary form must reproduce the above copyright notice, this list
 *       of conditions and the following disclaimer in the documentation and/or other materials
 *       provided with the distribution.
 *
 * THIS SOFTWARE IS PROVIDED BY <MARIUSZ GROMADA> ``AS IS'' AND ANY EXPRESS OR IMPLIED
 * WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
 * FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL <COPYRIGHT HOLDER> OR
 * CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR
 * CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR
 * SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON
 * ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING
 * NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF
 * ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 *
 * The views and conclusions contained in the software and documentation are those of the
 * authors and should not be interpreted as representing official policies, either expressed
 * or implied, of MARIUSZ GROMADA.
 *
 * If you have any questions/bugs feel free to contact:
 *
 *     Mariusz Gromada
 *     mariuszgromada.org@gmail.com
 *     http://mathparser.org
 *     http://mathspace.pl
 *     http://janetsudoku.mariuszgromada.org
 *     http://github.com/mariuszgromada/MathParser.org-mXparser
 *     http://mariuszgromada.github.io/MathParser.org-mXparser
 *     http://mxparser.sourceforge.net
 *     http://bitbucket.org/mariuszgromada/mxparser
 *     http://mxparser.codeplex.com
 *     http://github.com/mariuszgromada/Janet-Sudoku
 *     http://janetsudoku.codeplex.com
 *     http://sourceforge.net/projects/janetsudoku
 *     http://bitbucket.org/mariuszgromada/janet-sudoku
 *     http://github.com/mariuszgromada/MathParser.org-mXparser
 *
 *                              Asked if he believes in one God, a mathematician answered:
 *                              "Yes, up to isomorphism."
 */
using org.mariuszgromada.math.mxparser.parsertokens;
using System;
using System.Collections.Generic;

namespace org.mariuszgromada.math.mxparser.regressiontesting
{
	/**
	 * RegTestExpressionAPI - regression tests for the expression API
	 *
	 * @author         <b>Mariusz Gromada</b><br>
	 *                 <a href="mailto:mariuszgromada.org@gmail.com">mariuszgromada.org@gmail.com</a><br>
	 *                 <a href="http://mathspace.pl" target="_blank">MathSpace.pl</a><br>
	 *                 <a href="http://mathparser.org" target="_blank">MathParser.org - mXparser project page</a><br>
	 *                 <a href="http://github.com/mariuszgromada/MathParser.org-mXparser" target="_blank">mXparser on GitHub</a><br>
	 *                 <a href="http://mxparser.sourceforge.net" target="_blank">mXparser on SourceForge</a><br>
	 *                 <a href="http://bitbucket.org/mariuszgromada/mxparser" target="_blank">mXparser on Bitbucket</a><br>
	 *                 <a href="http://mxparser.codeplex.com" target="_blank">mXparser on CodePlex</a><br>
	 *                 <a href="http://janetsudoku.mariuszgromada.org" target="_blank">Janet Sudoku - project web page</a><br>
	 *                 <a href="http://github.com/mariuszgromada/Janet-Sudoku" target="_blank">Janet Sudoku on GitHub</a><br>
	 *                 <a href="http://janetsudoku.codeplex.com" target="_blank">Janet Sudoku on CodePlex</a><br>
	 *                 <a href="http://sourceforge.net/projects/janetsudoku" target="_blank">Janet Sudoku on SourceForge</a><br>
	 *                 <a href="http://bitbucket.org/mariuszgromada/janet-sudoku" target="_blank">Janet Sudoku on BitBucket</a><br>
	 *
	 * @version        4.1.0
	 *
	 * @see Expression
	 */
	[CLSCompliant(true)]
	public class RegTestExpressionAPI {
		/**
		 * Runs API regression tests.
		 *
		 * @return Number of tests with error result.
		 */
		public static int Start() {
			long start = mXparser.currentTimeMillis();
			bool syn1, syn2, syn3, syn4, syn5, syn6, syn7, syn8, b1, b2, b3;
			String s1, s2;
			int i1, i2, n1, n2, n3, n4, n5, n6;
			Argument A1, A2, A3, A4, A5;
			Function F1, F2, F3, F4, F5;
			Constant C1, C2, C3, C4, C5;
			double d1, d2, d3;
			Constant c1 = new Constant("c1",1);
			Constant c2 = new Constant("c2",2);
			Constant c3 = new Constant("c3",3);
			//Constant c4 = new Constant("c4",4);
			Constant c5 = new Constant("c5",5);
			Constant c6 = new Constant("c6",6);
			Function f1 = new Function("f1","1","x");
			Function f2 = new Function("f2","2","x");
			Function f3 = new Function("f3","3","x");
			Function f4 = new Function("f4","4","x");
			//Function f5 = new Function("f5","5","x");
			Function f6 = new Function("f6","6","x");
			Function f7 = new Function("f7","7","x");
			Argument a1 = new Argument("a1",1);
			Argument a2 = new Argument("a2",2);
			Argument a3 = new Argument("a3",3);
			Argument a4 = new Argument("a4",4);
			Argument a5 = new Argument("a5",5);
			Argument a6 = new Argument("a6",6);
			Argument a7 = new Argument("a7",7);
			//Argument a8 = new Argument("a8",8);
			bool[] test = new bool[100];
			for (int i = 0; i < 100; i++)
				test[i] = false;
			Expression e;
			int testId = -1;
			/*
			 * 0. public Expression()
			 */
			testId++;
			e = new Expression();
			if (	e.getExpressionString().Equals("")
					&& e.getArgumentsNumber() == 0
					&& e.getConstantsNumber() == 0
					&& e.getFunctionsNumber() == 0	)
				test[testId] = true;
			/*
			 * 1.
			 */
			testId++;
			e = new Expression("a1+c2", a1, a2, a3, a4, a5);
			if (	e.getExpressionString().Equals("a1+c2")
					&& e.getArgumentsNumber() == 5
					&& e.getConstantsNumber() == 0
					&& e.getFunctionsNumber() == 0	)
				test[testId] = true;
			/*
			 * 2.
			 */
			testId++;
			e = new Expression("a1+c2", a1, f1, a2, f2, a3, a4, f3, a5, f4);
			if (	e.getExpressionString().Equals("a1+c2")
					&& e.getArgumentsNumber() == 5
					&& e.getConstantsNumber() == 0
					&& e.getFunctionsNumber() == 4	)
				test[testId] = true;
			/*
			 * 3
			 */
			testId++;
			e = new Expression("a1+c2", a1, a2, c1, c2, a3, a4, c5, a5, f1, f2, f3, f4);
			if (	e.getExpressionString().Equals("a1+c2")
					&& e.getArgumentsNumber() == 5
					&& e.getConstantsNumber() == 3
					&& e.getFunctionsNumber() == 4	)
				test[testId] = true;
			/*
			 * 4. void setExpressionString(String expressionString), String getExpressionString(), void clearExpressionString()
			 */
			testId++;
			syn1 = e.checkSyntax();
			e.setExpressionString("c2+a1");
			syn2 = e.getSyntaxStatus();
			syn3 = e.checkSyntax();
			s1 = e.getExpressionString();
			syn4 = e.getSyntaxStatus();
			syn5 = e.checkSyntax();
			e.clearExpressionString();
			syn6 = e.getSyntaxStatus();
			syn7 = e.checkSyntax();
			s2 = e.getExpressionString();
			syn8 = e.getSyntaxStatus();
			if (	s1.Equals("c2+a1")
					&& s2.Equals("")
					&& syn1 == Expression.NO_SYNTAX_ERRORS
					&& syn2 == Expression.SYNTAX_ERROR_OR_STATUS_UNKNOWN
					&& syn3 == Expression.NO_SYNTAX_ERRORS
					&& syn4 == Expression.NO_SYNTAX_ERRORS
					&& syn5 == Expression.NO_SYNTAX_ERRORS
					&& syn6 == Expression.SYNTAX_ERROR_OR_STATUS_UNKNOWN
					&& syn7 == Expression.SYNTAX_ERROR_OR_STATUS_UNKNOWN
					&& syn8 == Expression.SYNTAX_ERROR_OR_STATUS_UNKNOWN
					)
				test[testId] = true;
			/*
			 * 5. void setDescription(String description), String getDescription(), void clearDescription()
			 */
			testId++;
			e.setExpressionString("c1+a2");
			syn1 = e.checkSyntax();
			e.setDescription("opis");
			s1 = e.getDescription();
			e.clearDescription();
			s2 = e.getDescription();
			syn2 = e.getSyntaxStatus();
			if (	s1.Equals("opis")
					&& s2.Equals("")
					&& syn1 == Expression.NO_SYNTAX_ERRORS
					&& syn2 == Expression.NO_SYNTAX_ERRORS
					)
				test[testId] = true;
			/*
			 * 6. void setVerboseMode(), boolean getVerboseMode(), void setSilentMode()
			 */
			testId++;
			syn1 = e.checkSyntax();
			b1 = e.getVerboseMode();
			e.setVerboseMode();
			b2 = e.getVerboseMode();
			e.setSilentMode();
			b3 = e.getVerboseMode();
			syn2 = e.getSyntaxStatus();
			if (	b1 == false
					&& b2 == true
					&& b3 == false
					&& syn1 == Expression.NO_SYNTAX_ERRORS
					&& syn2 == Expression.NO_SYNTAX_ERRORS
					)
				test[testId] = true;
			/*
			 * 7.
			 * public boolean getRecursiveMode()
			 */
			Function fa = new Function("f(x,y)=sin(x)+cos(y)");
			Function fb = new Function("f(x,y)=sin(x)+cos(y)+f(1,2)");
			testId++;
			syn1=fa.checkSyntax();
			syn2=fb.checkSyntax();
			b1 = fa.getRecursiveMode();
			b2 = fb.getRecursiveMode();
			if (	b1 == false
					&& b2 == true
					&& syn1 == Expression.NO_SYNTAX_ERRORS
					&& syn2 == Expression.NO_SYNTAX_ERRORS
					)
				test[testId] = true;
			/*
			 * 8.
			 * Expression(String expressionString)
			 */
			testId++;
			e = new Expression("1+2");
			if (	e.getExpressionString().Equals("1+2")
					&& e.getArgumentsNumber() == 0
					&& e.getConstantsNumber() == 0
					&& e.getFunctionsNumber() == 0	)
				test[testId] = true;
			/*
			 * 9.
			 * Expression(String expressionString)
			 */
			testId++;
			e = new Expression("1+2", a1, a2, a3);
			if (	e.getExpressionString().Equals("1+2")
					&& e.getArgumentsNumber() == 3
					&& e.getConstantsNumber() == 0
					&& e.getFunctionsNumber() == 0	)
				test[testId] = true;
			/*
			 * 10.
			 * void addArguments(Argument... arguments)
			 * void addArguments( ArrayList<Argument> argumentsList)
			 * defineArguments(String... argumentsNames)
			 * defineArgument(String argumentName, double argumentValue)
			 */
			testId++;
			e = new Expression("1+2");
			syn1 = e.checkSyntax();
			e.addDefinitions(a6, a7);
			syn2 = e.getSyntaxStatus();
			syn3 = e.checkSyntax();
			e.addDefinitions(a1, a2, a3, a4, a5);
			syn4 = e.getSyntaxStatus();
			syn5 = e.checkSyntax();
			e.defineArguments("x1", "x2", "x3");
			syn6 = e.getSyntaxStatus();
			syn7 = e.checkSyntax();
			e.defineArgument("x", 1);
			syn8 = e.getSyntaxStatus();
			if (	e.getExpressionString().Equals("1+2")
					&& e.getArgumentsNumber() == 11
					&& e.getConstantsNumber() == 0
					&& e.getFunctionsNumber() == 0
					&& syn1 == Expression.NO_SYNTAX_ERRORS
					&& syn2 == Expression.SYNTAX_ERROR_OR_STATUS_UNKNOWN
					&& syn3 == Expression.NO_SYNTAX_ERRORS
					&& syn4 == Expression.SYNTAX_ERROR_OR_STATUS_UNKNOWN
					&& syn5 == Expression.NO_SYNTAX_ERRORS
					&& syn6 == Expression.SYNTAX_ERROR_OR_STATUS_UNKNOWN
					&& syn7 == Expression.NO_SYNTAX_ERRORS
					&& syn8 == Expression.SYNTAX_ERROR_OR_STATUS_UNKNOWN
						)
				test[testId] = true;
			/*
			 * 11.
			 * int getArgumentIndex(String argumentName)
			 * Argument getArgument(String argumentName)
			 * Argument getArgument(int argumentIndex)
			 * int getArgumentsNumber()
			 */
			testId++;
			syn1 = e.checkSyntax();
			i1 = e.getArgumentIndex("asdsa"); //-1
			i2 = e.getArgumentIndex("x1"); //7
			A1 = e.getArgument("asasas"); //null
			A2 = e.getArgument("a2"); //a2
			A3 = e.getArgument(-1); //null
			A4 = e.getArgument(23);//null
			A5 = e.getArgument(1);//a7
			n1 = e.getArgumentsNumber();//11
			syn2 = e.getSyntaxStatus();
			if (	i1 == -1
					&& i2 == 7
					&& A1 == null
					&& A2 == a2
					&& A3 == null
					&& A4 == null
					&& A5 == a7
					&& n1 == 11
					&& syn1 == Expression.NO_SYNTAX_ERRORS
					&& syn2 == Expression.NO_SYNTAX_ERRORS
					)
				test[testId] = true;
			/*
			 * 12.
			 * void setArgumentValue
			 * double getArgumentValue
			 */
			testId++;
			syn1 = e.checkSyntax();
			d1 = e.getArgumentValue("a1");
			syn2 = e.getSyntaxStatus();
			e.setArgumentValue("asds", 1);
			syn3 = e.getSyntaxStatus();
			syn4 = e.checkSyntax();
			e.setArgumentValue("a1", 10);
			syn4 = e.getSyntaxStatus();
			d2 = e.getArgumentValue("asdfasdf");
			d3 = e.getArgumentValue("a1");
			syn5 = e.getSyntaxStatus();
			if (	d1 == 1
					&& Double.IsNaN(d2)
					&& d3 == 10
					&& syn1 == Expression.NO_SYNTAX_ERRORS
					&& syn2 == Expression.NO_SYNTAX_ERRORS
					&& syn3 == Expression.NO_SYNTAX_ERRORS
					&& syn4 == Expression.NO_SYNTAX_ERRORS
					&& syn5 == Expression.NO_SYNTAX_ERRORS
					)
				test[testId] = true;
			/*
			 * 13.
			 * void removeArguments(String... argumentsNames)
			 * void removeArguments(Argument... arguments)
			 * void removeAllArguments()
			 */
			testId++;
			e.setExpressionString("1+2");
			syn1 = e.checkSyntax();
			n1 = e.getArgumentsNumber();
			e.removeArguments("asfdf");
			syn2 = e.getSyntaxStatus();
			n2 = e.getArgumentsNumber();
			e.removeArguments("x1","x2");
			n3 = e.getArgumentsNumber();
			syn3 = e.checkSyntax();
			e.removeArguments(a3);
			n4 = e.getArgumentsNumber();
			e.removeArguments(a1,a2);
			syn4 = e.getSyntaxStatus();
			n5 = e.getArgumentsNumber();
			syn5 = e.checkSyntax();
			e.removeAllArguments();
			n6 = e.getArgumentsNumber();
			syn6 = e.getSyntaxStatus();
			if (	n2 == n1
					&& n2-n3 == 2
					&& n3-n4 == 1
					&& n4-n5 == 2
					&& n6 == 0
					&& syn1 == Expression.NO_SYNTAX_ERRORS
					&& syn2 == Expression.SYNTAX_ERROR_OR_STATUS_UNKNOWN
					&& syn3 == Expression.NO_SYNTAX_ERRORS
					&& syn4 == Expression.SYNTAX_ERROR_OR_STATUS_UNKNOWN
					&& syn5 == Expression.NO_SYNTAX_ERRORS
					&& syn6 == Expression.SYNTAX_ERROR_OR_STATUS_UNKNOWN
					)
				test[testId] = true;
			/*
			 * 14.
			 * void addConstants(Constant... constants)
			 * void addConstants( ArrayList<Constant> constantsList)
			 * void defineConstant(String constantName, double constantValue)
			 */
			testId++;
			e = new Expression("1+2", new Constant("a=5"));
			syn1 = e.checkSyntax();
			e.addDefinitions(c5, c6);
			syn2 = e.getSyntaxStatus();
			syn3 = e.checkSyntax();
			e.addDefinitions(c1, c2, c3, c5, c6);
			syn4 = e.getSyntaxStatus();
			syn5 = e.checkSyntax();
			e.defineConstant("cx1",1);
			e.removeDefinitions(c5, c6);
			syn6 = e.checkSyntax();
			e.removeDefinitions(c5, c6);
			if (	e.getExpressionString().Equals("1+2")
					&& e.getArgumentsNumber() == 0
					&& e.getConstantsNumber() == 5
					&& e.getFunctionsNumber() == 0
					&& syn1 == Expression.NO_SYNTAX_ERRORS
					&& syn2 == Expression.SYNTAX_ERROR_OR_STATUS_UNKNOWN
					&& syn3 == Expression.NO_SYNTAX_ERRORS
					&& syn4 == Expression.SYNTAX_ERROR_OR_STATUS_UNKNOWN
					&& syn5 == Expression.SYNTAX_ERROR_OR_STATUS_UNKNOWN
					&& syn6 == Expression.NO_SYNTAX_ERRORS
						)
				test[testId] = true;
			/*
			 * 15.
			 * int getConstantIndex(String constantName)
			 * Constant getConstant(String constantName)
			 * Constant getConstant(int constantIndex)
			 * int getConstantsNumber()
			 */
			testId++;
			syn1 = e.checkSyntax();
			i1 = e.getConstantIndex("asdsa"); //-1
			i2 = e.getConstantIndex("c6"); //-1
			C1 = e.getConstant("asasas"); //null
			C2 = e.getConstant("c1"); //c1
			C3 = e.getConstant(-1); //null
			C4 = e.getConstant(23);//null
			C5 = e.getConstant(1);//c1
			n1 = e.getConstantsNumber();//5
			syn2 = e.getSyntaxStatus();
			if (	i1 == -1
					&& i2 == -1
					&& C1 == null
					&& C2 == c1
					&& C3 == null
					&& C4 == null
					&& C5 == c1
					&& n1 == 5
					&& syn1 == Expression.NO_SYNTAX_ERRORS
					&& syn2 == Expression.NO_SYNTAX_ERRORS
					)
				test[testId] = true;
			/*
			 * 16.
			 * void removeConstants(String... constantsNames)
			 * void removeConstants(Constant... constants)
			 * void removeAllConstants()
			 */
			testId++;
			e.defineConstant("cx2",1);
			e.setExpressionString("1+2");
			syn1 = e.checkSyntax();
			n1 = e.getConstantsNumber();
			e.removeConstants("asfdf");
			syn2 = e.getSyntaxStatus();
			n2 = e.getConstantsNumber();
			e.removeConstants("cx1","cx2");
			n3 = e.getConstantsNumber();
			syn3 = e.checkSyntax();
			e.removeConstants(c1);
			n4 = e.getConstantsNumber();
			e.removeConstants(c2,c3);
			syn4 = e.getSyntaxStatus();
			n5 = e.getConstantsNumber();
			syn5 = e.checkSyntax();
			e.removeAllConstants();
			n6 = e.getConstantsNumber();
			syn6 = e.getSyntaxStatus();
			if (	n2 == n1
					&& n2-n3 == 2
					&& n3-n4 == 1
					&& n4-n5 == 2
					&& n6 == 0
					&& syn1 == Expression.NO_SYNTAX_ERRORS
					&& syn2 == Expression.SYNTAX_ERROR_OR_STATUS_UNKNOWN
					&& syn3 == Expression.NO_SYNTAX_ERRORS
					&& syn4 == Expression.SYNTAX_ERROR_OR_STATUS_UNKNOWN
					&& syn5 == Expression.NO_SYNTAX_ERRORS
					&& syn6 == Expression.SYNTAX_ERROR_OR_STATUS_UNKNOWN
					)
				test[testId] = true;
			/*
			 * 17.
			 * void addFunctions(Function... functions)
			 * void addFunctions( ArrayList<Function> functionsList)
			 * void defineFunction(String functionName, String  functionExpressionString,...
			 */
			testId++;
			e = new Expression("1+2");
			syn1 = e.checkSyntax();
			e.addDefinitions(f6, f7);
			syn2 = e.getSyntaxStatus();
			syn3 = e.checkSyntax();
			e.addDefinitions(f1, f2, f3, f4, f6);
			syn4 = e.getSyntaxStatus();
			e.removeDefinitions(f6);
			syn5 = e.checkSyntax();
			e.defineFunction("ff1", "1", "x");
			syn6 = e.getSyntaxStatus();
			if (	e.getExpressionString().Equals("1+2")
					&& e.getArgumentsNumber() == 0
					&& e.getConstantsNumber() == 0
					&& e.getFunctionsNumber() == 7
					&& syn1 == Expression.NO_SYNTAX_ERRORS
					&& syn2 == Expression.SYNTAX_ERROR_OR_STATUS_UNKNOWN
					&& syn3 == Expression.NO_SYNTAX_ERRORS
					&& syn4 == Expression.SYNTAX_ERROR_OR_STATUS_UNKNOWN
					&& syn5 == Expression.NO_SYNTAX_ERRORS
					&& syn6 == Expression.SYNTAX_ERROR_OR_STATUS_UNKNOWN
						)
				test[testId] = true;
			/*
			 * 18.
			 * int getFunctionIndex(String functionName)
			 * Function getFunction(String functionName)
			 * Function getFunction(int functionIndex)
			 * int getFunctionsNumber()
			 */
			testId++;
			syn1 = e.checkSyntax();
			i1 = e.getFunctionIndex("asdsa"); //-1
			i2 = e.getFunctionIndex("f7"); //0
			F1 = e.getFunction("asasas"); //null
			F2 = e.getFunction("f1"); //f1
			F3 = e.getFunction(-1); //null
			F4 = e.getFunction(23);//null
			F5 = e.getFunction(0);//f7
			n1 = e.getFunctionsNumber();//7
			syn2 = e.getSyntaxStatus();
			if (	i1 == -1
					&& i2 == 0
					&& F1 == null
					&& F2 == f1
					&& F3 == null
					&& F4 == null
					&& F5 == f7
					&& n1 == 7
					&& syn1 == Expression.NO_SYNTAX_ERRORS
					&& syn2 == Expression.NO_SYNTAX_ERRORS
					)
				test[testId] = true;
			/*
			 * 19.
			 * void removeFunctions(String... functionsNames)
			 * void removeFunctions(Function... functions)
			 * void removeAllFunctions()
			 */
			testId++;
			e.setExpressionString("1+2");
			syn1 = e.checkSyntax();
			n1 = e.getFunctionsNumber();
			e.removeFunctions("asfdf");
			syn2 = e.getSyntaxStatus();
			n2 = e.getFunctionsNumber();
			e.removeFunctions("f1","f2");
			n3 = e.getFunctionsNumber();
			syn3 = e.checkSyntax();
			e.removeFunctions(f3);
			n4 = e.getFunctionsNumber();
			e.removeFunctions(f6,f7);
			syn4 = e.getSyntaxStatus();
			n5 = e.getFunctionsNumber();
			syn5 = e.checkSyntax();
			e.removeAllFunctions();
			n6 = e.getFunctionsNumber();
			syn6 = e.getSyntaxStatus();
			if (	n2 == n1
					&& n2-n3 == 2
					&& n3-n4 == 1
					&& n4-n5 == 2
					&& n6 == 0
					&& syn1 == Expression.NO_SYNTAX_ERRORS
					&& syn2 == Expression.SYNTAX_ERROR_OR_STATUS_UNKNOWN
					&& syn3 == Expression.NO_SYNTAX_ERRORS
					&& syn4 == Expression.SYNTAX_ERROR_OR_STATUS_UNKNOWN
					&& syn5 == Expression.NO_SYNTAX_ERRORS
					&& syn6 == Expression.SYNTAX_ERROR_OR_STATUS_UNKNOWN
					)
				test[testId] = true;
			/*
			 * 20.
			 * double calculate()
			 * String getHelp()
			 * String getHelp(String word)
			 * String getLicense()
			 */
			testId++;
			syn1 = e.checkSyntax();
			d1 = e.calculate();
			syn2 = e.getSyntaxStatus();
			if (	syn1 == Expression.NO_SYNTAX_ERRORS
					&& syn2 == Expression.NO_SYNTAX_ERRORS
					&& d1 == 3)
				test[testId] = true;

			/*
			 * 21. Tokens
			 */
			testId++;
			e = new Expression("1+(2+3)-sin(10)");
			List<Token> tokens = e.getCopyOfInitialTokens();
			mXparser.consolePrintTokens(tokens);
			if (
					(tokens[0].tokenStr.Equals("1")) &&
					(tokens[1].tokenStr.Equals("+")) &&
					(tokens[2].tokenStr.Equals("(")) &&
					(tokens[3].tokenStr.Equals("2")) &&
					(tokens[4].tokenStr.Equals("+")) &&
					(tokens[5].tokenStr.Equals("3")) &&
					(tokens[6].tokenStr.Equals(")")) &&
					(tokens[7].tokenStr.Equals("-")) &&
					(tokens[8].tokenStr.Equals("sin")) &&
					(tokens[9].tokenStr.Equals("(")) &&
					(tokens[10].tokenStr.Equals("10")) &&
					(tokens[11].tokenStr.Equals(")")) &&

					(tokens[0].tokenTypeId == ParserSymbol.NUMBER_TYPE_ID) &&
					(tokens[1].tokenTypeId == Operator.TYPE_ID) &&
					(tokens[2].tokenTypeId == ParserSymbol.TYPE_ID) &&
					(tokens[3].tokenTypeId == ParserSymbol.NUMBER_TYPE_ID) &&
					(tokens[4].tokenTypeId == Operator.TYPE_ID) &&
					(tokens[5].tokenTypeId == ParserSymbol.NUMBER_TYPE_ID) &&
					(tokens[6].tokenTypeId == ParserSymbol.TYPE_ID) &&
					(tokens[7].tokenTypeId == Operator.TYPE_ID) &&
					(tokens[8].tokenTypeId == Function1Arg.TYPE_ID) &&
					(tokens[9].tokenTypeId == ParserSymbol.TYPE_ID) &&
					(tokens[10].tokenTypeId == ParserSymbol.NUMBER_TYPE_ID) &&
					(tokens[11].tokenTypeId == ParserSymbol.TYPE_ID) &&

					(tokens[0].tokenLevel == 0) &&
					(tokens[1].tokenLevel == 0) &&
					(tokens[2].tokenLevel == 1) &&
					(tokens[3].tokenLevel == 1) &&
					(tokens[4].tokenLevel == 1) &&
					(tokens[5].tokenLevel == 1) &&
					(tokens[6].tokenLevel == 1) &&
					(tokens[7].tokenLevel == 0) &&
					(tokens[8].tokenLevel == 1) &&
					(tokens[9].tokenLevel == 2) &&
					(tokens[10].tokenLevel == 2) &&
					(tokens[11].tokenLevel == 2)

			) test[testId] = true;
			/*
			 * 22. Invalid tokens
			 */
			testId++;
			e = new Expression("token1+toke2n*sin(token3-t3^t5)^t45+pi-pie+e");
			tokens = e.getCopyOfInitialTokens();
			mXparser.consolePrintTokens(tokens);
			if (
					(tokens[0].tokenStr.Equals("token1")) &&
					(tokens[1].tokenStr.Equals("+")) &&
					(tokens[2].tokenStr.Equals("toke2n")) &&
					(tokens[3].tokenStr.Equals("*")) &&
					(tokens[4].tokenStr.Equals("sin")) &&
					(tokens[5].tokenStr.Equals("(")) &&
					(tokens[6].tokenStr.Equals("token3")) &&
					(tokens[7].tokenStr.Equals("-")) &&
					(tokens[8].tokenStr.Equals("t3")) &&
					(tokens[9].tokenStr.Equals("^")) &&
					(tokens[10].tokenStr.Equals("t5")) &&
					(tokens[11].tokenStr.Equals(")")) &&
					(tokens[12].tokenStr.Equals("^")) &&
					(tokens[13].tokenStr.Equals("t45")) &&
					(tokens[14].tokenStr.Equals("+")) &&
					(tokens[15].tokenStr.Equals("pi")) &&
					(tokens[16].tokenStr.Equals("-")) &&
					(tokens[17].tokenStr.Equals("pie")) &&
					(tokens[18].tokenStr.Equals("+")) &&
					(tokens[19].tokenStr.Equals("e")) &&

					(tokens[0].tokenTypeId == Token.NOT_MATCHED) &&
					(tokens[1].tokenTypeId == Operator.TYPE_ID) &&
					(tokens[2].tokenTypeId == Token.NOT_MATCHED) &&
					(tokens[3].tokenTypeId == Operator.TYPE_ID) &&
					(tokens[4].tokenTypeId == Function1Arg.TYPE_ID) &&
					(tokens[5].tokenTypeId == ParserSymbol.TYPE_ID) &&
					(tokens[6].tokenTypeId == Token.NOT_MATCHED) &&
					(tokens[7].tokenTypeId == Operator.TYPE_ID) &&
					(tokens[8].tokenTypeId == Token.NOT_MATCHED) &&
					(tokens[9].tokenTypeId == Operator.TYPE_ID) &&
					(tokens[10].tokenTypeId == Token.NOT_MATCHED) &&
					(tokens[11].tokenTypeId == ParserSymbol.TYPE_ID) &&
					(tokens[12].tokenTypeId == Operator.TYPE_ID) &&
					(tokens[13].tokenTypeId == Token.NOT_MATCHED) &&
					(tokens[14].tokenTypeId == Operator.TYPE_ID) &&
					(tokens[15].tokenTypeId == ConstantValue.TYPE_ID) &&
					(tokens[16].tokenTypeId == Operator.TYPE_ID) &&
					(tokens[17].tokenTypeId == Token.NOT_MATCHED) &&
					(tokens[18].tokenTypeId == Operator.TYPE_ID) &&
					(tokens[19].tokenTypeId == ConstantValue.TYPE_ID) &&

					(tokens[0].tokenLevel == 0) &&
					(tokens[1].tokenLevel == 0) &&
					(tokens[2].tokenLevel == 0) &&
					(tokens[3].tokenLevel == 0) &&
					(tokens[4].tokenLevel == 1) &&
					(tokens[5].tokenLevel == 2) &&
					(tokens[6].tokenLevel == 2) &&
					(tokens[7].tokenLevel == 2) &&
					(tokens[8].tokenLevel == 2) &&
					(tokens[9].tokenLevel == 2) &&
					(tokens[10].tokenLevel == 2) &&
					(tokens[11].tokenLevel == 2) &&
					(tokens[12].tokenLevel == 0) &&
					(tokens[13].tokenLevel == 0) &&
					(tokens[14].tokenLevel == 0) &&
					(tokens[15].tokenLevel == 0) &&
					(tokens[16].tokenLevel == 0) &&
					(tokens[17].tokenLevel == 0) &&
					(tokens[18].tokenLevel == 0) &&
					(tokens[19].tokenLevel == 0)

			) test[testId] = true;
			/*
			 * 23. Function Extension - calculate()
			 */
			testId++;
			Function ff = new Function("ff", new FunExt());
			if (ff.calculate(2, 3) == 6) test[testId] = true;
			/*
			 * 24. Function Extension - setArgumentValue - calculate
			 */
			testId++;
			ff = new Function("ff", new FunExt());
			ff.setArgumentValue(0, 3);
			ff.setArgumentValue(1, 4);
			if (ff.calculate() == 12) test[testId] = true;
			/*
			 * 25. Function Extension - parameters
			 */
			testId++;
			ff = new Function("ff", new FunExt());
			if (
					(ff.getParametersNumber() == 2) &&
					(ff.getFunctionBodyType() == Function.BODY_EXTENDED) &&
					(ff.checkSyntax() == Function.NO_SYNTAX_ERRORS)
				) test[testId] = true;
			/*
			 * 26. Function Extension - calculate
			 */
			testId++;
			ff = new Function("ff", new FunExt());
			Argument x = new Argument("x = 5");
			Argument y = new Argument("y = 6");
			if (ff.calculate(x, y) == 30) test[testId] = true;
			/*
			 * 27. Invalid tokens looks like
			 */
			testId++;
			e = new Expression("1pi+2pi3+((_d1(a)+(_d^_g)))))");
			tokens = e.getCopyOfInitialTokens();
			mXparser.consolePrintTokens(tokens);
			if (
					(tokens[0].tokenStr.Equals("1pi")) &&
					(tokens[1].tokenStr.Equals("+")) &&
					(tokens[2].tokenStr.Equals("2pi3")) &&
					(tokens[3].tokenStr.Equals("+")) &&
					(tokens[4].tokenStr.Equals("(")) &&
					(tokens[5].tokenStr.Equals("(")) &&
					(tokens[6].tokenStr.Equals("_d1")) &&
					(tokens[7].tokenStr.Equals("(")) &&
					(tokens[8].tokenStr.Equals("a")) &&
					(tokens[9].tokenStr.Equals(")")) &&
					(tokens[10].tokenStr.Equals("+")) &&
					(tokens[11].tokenStr.Equals("(")) &&
					(tokens[12].tokenStr.Equals("_d")) &&
					(tokens[13].tokenStr.Equals("^")) &&
					(tokens[14].tokenStr.Equals("_g")) &&
					(tokens[15].tokenStr.Equals(")")) &&
					(tokens[16].tokenStr.Equals(")")) &&
					(tokens[17].tokenStr.Equals(")")) &&
					(tokens[18].tokenStr.Equals(")")) &&
					(tokens[19].tokenStr.Equals(")")) &&

					(tokens[0].looksLike.Equals("error")) &&
					(tokens[2].looksLike.Equals("error")) &&
					(tokens[6].looksLike.Equals("function")) &&
					(tokens[8].looksLike.Equals("argument")) &&
					(tokens[12].looksLike.Equals("argument")) &&
					(tokens[14].looksLike.Equals("argument"))
				) test[testId] = true;
			/*
			 * 28. Check Lex Syntax
			 */
			testId++;
			e = new Expression("1+2+3+(4+5)+a+b");
			if (
					(e.checkSyntax() == Expression.SYNTAX_ERROR_OR_STATUS_UNKNOWN) &&
					(e.checkLexSyntax() == Expression.NO_SYNTAX_ERRORS)
				) test[testId] = true;
			/*
			 * 29. Check Lex Syntax
			 */
			testId++;
			e = new Expression("1+2+3+(4+5)+a)+b");
			if (
					(e.checkSyntax() == Expression.SYNTAX_ERROR_OR_STATUS_UNKNOWN) &&
					(e.checkLexSyntax() == Expression.SYNTAX_ERROR_OR_STATUS_UNKNOWN)
				) test[testId] = true;
			/*
			 * 30. Tokens to remove
			 */
			testId++;
			String t = null;
			mXparser.removeBuiltinTokens("sin");
			mXparser.removeBuiltinTokens("sin");
			mXparser.removeBuiltinTokens("cos");
			mXparser.removeBuiltinTokens("sin");
			mXparser.removeBuiltinTokens("sin", "cos", t, "", "tg");
			mXparser.removeBuiltinTokens(t);
			mXparser.unremoveBuiltinTokens(t);
			mXparser.unremoveBuiltinTokens(t, "");
			mXparser.unremoveBuiltinTokens("sin", "tg");
			String[] tokensToRemove1 = mXparser.getBuiltinTokensToRemove();
			mXparser.unremoveAllBuiltinTokens();
			String[] tokensToRemove2 = mXparser.getBuiltinTokensToRemove();
			if (
					(tokensToRemove1.Length == 1) &&
					(tokensToRemove1[0].Equals("cos")) &&
					(tokensToRemove2.Length == 0)
				) test[testId] = true;
			/*
			 * 31. Tokens to modify
			 */
			String u = null;
			testId++;
			mXparser.modifyBuiltinToken("sin", "SIN");
			mXparser.modifyBuiltinToken("cos", "");
			mXparser.modifyBuiltinToken("tan", u);
			mXparser.modifyBuiltinToken(u, u);
			mXparser.modifyBuiltinToken(u, "TAN");
			mXparser.modifyBuiltinToken("tg", "TG", "NEW TG");
			mXparser.modifyBuiltinToken("", "TG", "NEW TG");
			mXparser.modifyBuiltinToken(u, "TG", "NEW TG");
			mXparser.modifyBuiltinToken("sin", "TG", "NEW TG");
			mXparser.modifyBuiltinToken("cos", "COS", "NEW COS");
			mXparser.modifyBuiltinToken("cos", "COS1", "NEW COS1");
            String help = mXparser.getHelp("COS");
            String[,] tokensToModify1 = mXparser.getBuiltinTokensToModify();
			mXparser.unmodifyBuiltinTokens("", u, "SIN", "tg");
			String[,] tokensToModify2 = mXparser.getBuiltinTokensToModify();
			mXparser.unmodifyAllBuiltinTokens();
			String[,] tokensToModify3 = mXparser.getBuiltinTokensToModify();
			if (
					(tokensToModify1.GetLength(0) == 3) && (tokensToModify1.GetLength(1) == 3) &&
					(tokensToModify2.GetLength(0) == 1) && (tokensToModify2.GetLength(1) == 3) &&
					(tokensToModify3.GetLength(0) == 0) &&
					(tokensToModify1[0, 0].Equals("sin")) &&
					(tokensToModify1[0, 1].Equals("SIN")) &&
					(tokensToModify1[0, 2] == null) &&
					(tokensToModify1[1, 0].Equals("tg")) &&
					(tokensToModify1[1, 1].Equals("TG")) &&
					(tokensToModify1[1, 2].Equals("NEW TG")) &&
					(tokensToModify1[2, 0].Equals("cos")) &&
					(tokensToModify1[2, 1].Equals("COS")) &&
					(tokensToModify1[2, 2].Equals("NEW COS")) &&
					(tokensToModify2[0, 0].Equals("cos")) &&
					(tokensToModify2[0, 1].Equals("COS")) &&
					(tokensToModify2[0, 2].Equals("NEW COS")) &&
                    (help.Contains("COS(x)"))
                    ) test[testId] = true;
			/*
			 * 32. Recursion counter
			 */
			testId++;
			mXparser.setMaxAllowedRecursionDepth(100);
			int rc100 = mXparser.getMaxAllowedRecursionDepth();
			mXparser.setMaxAllowedRecursionDepth(200);
			int rc200 = mXparser.getMaxAllowedRecursionDepth();
			if ((rc100 == 100) && (rc200 == 200))
				test[testId] = true;
			/*
			 * 33. Override built-in tokens
			 */
			testId++;
			mXparser.setToOverrideBuiltinTokens();
			bool over1 = mXparser.checkIfsetToOverrideBuiltinTokens();
			mXparser.setNotToOverrideBuiltinTokens();
			bool over2 = mXparser.checkIfsetToOverrideBuiltinTokens();
			mXparser.setToOverrideBuiltinTokens();
			bool over3 = mXparser.checkIfsetToOverrideBuiltinTokens();
			mXparser.setNotToOverrideBuiltinTokens();
			bool over4 = mXparser.checkIfsetToOverrideBuiltinTokens();
			if ((over1 == true) && (over2 == false) && (over3 == true) && (over4 == false))
				test[testId] = true;
			/*
			 * 34. mXparser.getKeyWords
			 */
			testId++;
			List<KeyWord> keyWords = mXparser.getKeyWords("sin ");
			if (	(keyWords.Count == 4) &&
					(keyWords[0].wordString.Equals("sin")) &&
					(keyWords[1].wordString.Equals("asin")) &&
					(keyWords[2].wordString.Equals("arsin")) &&
					(keyWords[3].wordString.Equals("arcsin"))
					)
				test[testId] = true;
			/*
			 * 35. mXparser.getTokenType
			 */
			testId++;
			if ((mXparser.getTokenTypeDescription(BinaryRelation.TYPE_ID).Equals(BinaryRelation.TYPE_DESC)) &&
					(mXparser.getTokenTypeDescription(BitwiseOperator.TYPE_ID).Equals(BitwiseOperator.TYPE_DESC)) &&
					(mXparser.getTokenTypeDescription(BooleanOperator.TYPE_ID).Equals(BooleanOperator.TYPE_DESC)) &&
					(mXparser.getTokenTypeDescription(CalculusOperator.TYPE_ID).Equals(CalculusOperator.TYPE_DESC)) &&
					(mXparser.getTokenTypeDescription(ConstantValue.TYPE_ID).Equals(ConstantValue.TYPE_DESC)) &&
					(mXparser.getTokenTypeDescription(Function1Arg.TYPE_ID).Equals(Function1Arg.TYPE_DESC)) &&
					(mXparser.getTokenTypeDescription(Function2Arg.TYPE_ID).Equals(Function2Arg.TYPE_DESC)) &&
					(mXparser.getTokenTypeDescription(Function3Arg.TYPE_ID).Equals(Function3Arg.TYPE_DESC)) &&
					(mXparser.getTokenTypeDescription(FunctionVariadic.TYPE_ID).Equals(FunctionVariadic.TYPE_DESC)) &&
					(mXparser.getTokenTypeDescription(Operator.TYPE_ID).Equals(Operator.TYPE_DESC)) &&
					(mXparser.getTokenTypeDescription(ParserSymbol.TYPE_ID).Equals(ParserSymbol.TYPE_DESC)) &&
					(mXparser.getTokenTypeDescription(RandomVariable.TYPE_ID).Equals(RandomVariable.TYPE_DESC)) &&
					(mXparser.getTokenTypeDescription(Unit.TYPE_ID).Equals(Unit.TYPE_DESC)) &&
					(mXparser.getTokenTypeDescription(Argument.TYPE_ID).Equals(Argument.TYPE_DESC)) &&
					(mXparser.getTokenTypeDescription(Constant.TYPE_ID).Equals(Constant.TYPE_DESC)) &&
					(mXparser.getTokenTypeDescription(RecursiveArgument.TYPE_ID_RECURSIVE).Equals(RecursiveArgument.TYPE_DESC_RECURSIVE)) &&
					(mXparser.getTokenTypeDescription(Function.TYPE_ID).Equals(Function.TYPE_DESC))
					)
				test[testId] = true;
			/*
			 * 36. mXparser.convert2Decimal
			 */
			testId++;
			if (
					(mXparser.convOthBase2Decimal("11", 2) == 3.0) &&
					(mXparser.convOthBase2Decimal("011", 2) == 3.0) &&
					(mXparser.convOthBase2Decimal("000011", 2) == 3.0) &&
					(mXparser.convOthBase2Decimal("12", 3) == 5.0) &&
					(mXparser.convOthBase2Decimal("012", 3) == 5.0) &&
					(mXparser.convOthBase2Decimal("0012", 3) == 5.0) &&
					(mXparser.convOthBase2Decimal("123", 4) == 27.0) &&
					(mXparser.convOthBase2Decimal("0123", 4) == 27.0) &&
					(mXparser.convOthBase2Decimal("00123", 4) == 27.0) &&
					(mXparser.convOthBase2Decimal("1234", 5) == 194.0) &&
					(mXparser.convOthBase2Decimal("01234", 5) == 194.0) &&
					(mXparser.convOthBase2Decimal("001234", 5) == 194.0) &&
					(mXparser.convOthBase2Decimal("12345", 6) == 1865.0) &&
					(mXparser.convOthBase2Decimal("012345", 6) == 1865.0) &&
					(mXparser.convOthBase2Decimal("0012345", 6) == 1865.0) &&
					(mXparser.convOthBase2Decimal("123456", 7) == 22875.0) &&
					(mXparser.convOthBase2Decimal("0123456", 7) == 22875.0) &&
					(mXparser.convOthBase2Decimal("00123456", 7) == 22875.0) &&
					(mXparser.convOthBase2Decimal("1234567", 8) == 342391.0) &&
					(mXparser.convOthBase2Decimal("01234567", 8) == 342391.0) &&
					(mXparser.convOthBase2Decimal("01234567", 8) == 342391.0) &&
					(mXparser.convOthBase2Decimal("12345678", 9) == 6053444.0) &&
					(mXparser.convOthBase2Decimal("012345678", 9) == 6053444.0) &&
					(mXparser.convOthBase2Decimal("0012345678", 9) == 6053444.0) &&
					(mXparser.convOthBase2Decimal("123456789", 10) == 123456789.0) &&
					(mXparser.convOthBase2Decimal("0123456789", 10) == 123456789.0) &&
					(mXparser.convOthBase2Decimal("00123456789", 10) == 123456789.0) &&
					(mXparser.convOthBase2Decimal("123456789A", 11) == 2853116705.0) &&
					(mXparser.convOthBase2Decimal("0123456789A", 11) == 2853116705.0) &&
					(mXparser.convOthBase2Decimal("00123456789A", 11) == 2853116705.0) &&
					(mXparser.convOthBase2Decimal("123456789Ab", 12) == 73686780563.0) &&
					(mXparser.convOthBase2Decimal("0123456789Ab", 12) == 73686780563.0) &&
					(mXparser.convOthBase2Decimal("00123456789Ab", 12) == 73686780563.0) &&
					(mXparser.convOthBase2Decimal("123456789AbC", 13) == 2103299351334.0) &&
					(mXparser.convOthBase2Decimal("0123456789AbC", 13) == 2103299351334.0) &&
					(mXparser.convOthBase2Decimal("00123456789AbC", 13) == 2103299351334.0) &&
					(mXparser.convOthBase2Decimal("123456789AbCd", 14) == 65751519677857.0) &&
					(mXparser.convOthBase2Decimal("0123456789AbCd", 14) == 65751519677857.0) &&
					(mXparser.convOthBase2Decimal("00123456789AbCd", 14) == 65751519677857.0)
				) test[testId] = true;
			/*
			 * 37. mXparser.convert2Decimal - loop
			 */
			testId++;
			test[testId] = true;
			for (int decimalNumber = -10000; decimalNumber < 10000; decimalNumber++)
				for (int numeralSystemBase = 1; numeralSystemBase <= 36; numeralSystemBase++)
					if (mXparser.convOthBase2Decimal(mXparser.convDecimal2OthBase(decimalNumber, numeralSystemBase), numeralSystemBase) != decimalNumber) {
						test[testId] = false;
						break;
					}
			/*
			 * 38. mXparser.convert2Decimal and other - special cases
			 */
			testId++;
			char dc_1 = mXparser.digitChar(-1);
			char dc37 = mXparser.digitChar(37);
			int di = mXparser.digitIndex('�');
			double dec1 = mXparser.convOthBase2Decimal("", 1);
			double decNaN1 = mXparser.convOthBase2Decimal("1101", 0);
			double decNaN2 = mXparser.convOthBase2Decimal("1101", 37);
			double decNaN3 = mXparser.convOthBase2Decimal(null, 3);
			double decNaN4 = mXparser.convOthBase2Decimal("", 3);
			double decNaN5 = mXparser.convOthBase2Decimal("1234", 4);
			String strNaN1 = mXparser.convDecimal2OthBase(Double.NaN, 2);
			String strNaN2 = mXparser.convDecimal2OthBase(2, 0);
			String strNaN3 = mXparser.convDecimal2OthBase(2, 37);
			if ((dc_1 == '?') &&
					(dc37 == '?') &&
					(di == -1) &&
					(dec1 == 0) &&
					(Double.IsNaN(decNaN1)) &&
					(Double.IsNaN(decNaN2)) &&
					(Double.IsNaN(decNaN3)) &&
					(Double.IsNaN(decNaN4)) &&
					(Double.IsNaN(decNaN5)) &&
					(strNaN1.Equals("NaN")) &&
					(strNaN2.Equals("NaN")) &&
					(strNaN3.Equals("NaN"))
					)
				test[testId] = true;
			/*
			 * 39. mXparser.convert2Decimal - loop
			 */
			testId++;
			test[testId] = true;
			for (int decimalNumber = -10000; decimalNumber < 10000; decimalNumber++)
				for (int numeralSystemBase = 1; numeralSystemBase <= 36; numeralSystemBase++)
					if (mXparser.convOthBase2Decimal(mXparser.convDecimal2OthBase(decimalNumber, numeralSystemBase, 1)) != decimalNumber) {
						test[testId] = false;
						break;
					}
			/*
			 * 40. mXparser.convert2Decimal - loop
			 */
			testId++;
			test[testId] = true;
			for (int decimalNumber = -10000; decimalNumber < 10000; decimalNumber++)
				for (int numeralSystemBase = 1; numeralSystemBase <= 36; numeralSystemBase++)
					if (mXparser.convOthBase2Decimal(mXparser.convDecimal2OthBase(decimalNumber, numeralSystemBase, 2)) != decimalNumber) {
						test[testId] = false;
						break;
					}
			/*
			 * 41. mXparser.convert2Decimal - loop
			 */
			testId++;
			test[testId] = true;
			for (int decimalNumber = -10000; decimalNumber < 10000; decimalNumber++)
				for (int numeralSystemBase = 1; numeralSystemBase <= 36; numeralSystemBase++)
					if (mXparser.convOthBase2Decimal(mXparser.convDecimal2OthBase(decimalNumber, numeralSystemBase, 0), numeralSystemBase) != decimalNumber) {
						test[testId] = false;
						break;
					}
			/*
			 * 42. mXparser.get base
			 */
			testId++;
			if (
					(mXparser.getNumeralSystemBase("h.1234567890aBcDeF") == 16) &&
					(mXparser.getNumeralSystemBase("o.12345670") == 8) &&
					(mXparser.getNumeralSystemBase("b.101010") == 2) &&
					(mXparser.getNumeralSystemBase("b1.") == 1) &&
					(mXparser.getNumeralSystemBase("b2.01") == 2) &&
					(mXparser.getNumeralSystemBase("b3.012") == 3) &&
					(mXparser.getNumeralSystemBase("b4.0123") == 4) &&
					(mXparser.getNumeralSystemBase("b5.01234") == 5) &&
					(mXparser.getNumeralSystemBase("b6.012345") == 6) &&
					(mXparser.getNumeralSystemBase("b7.0123456") == 7) &&
					(mXparser.getNumeralSystemBase("b8.01234567") == 8) &&
					(mXparser.getNumeralSystemBase("b9.012345678") == 9) &&
					(mXparser.getNumeralSystemBase("b10.0123456789") == 10) &&
					(mXparser.getNumeralSystemBase("b11.0123456789a") == 11) &&
					(mXparser.getNumeralSystemBase("b12.0123456789ab") == 12) &&
					(mXparser.getNumeralSystemBase("b13.0123456789abc") == 13) &&
					(mXparser.getNumeralSystemBase("b14.0123456789abcd") == 14) &&
					(mXparser.getNumeralSystemBase("b15.0123456789abcde") == 15) &&
					(mXparser.getNumeralSystemBase("b16.0123456789abcdef") == 16) &&
					(mXparser.getNumeralSystemBase("b16.0123456789abcdef") == 16) &&
					(mXparser.getNumeralSystemBase("b17.0123456789abcdefg") == 17) &&
					(mXparser.getNumeralSystemBase("b18.0123456789abcdefgh") == 18) &&
					(mXparser.getNumeralSystemBase("b19.0123456789abcdefghi") == 19) &&
					(mXparser.getNumeralSystemBase("b20.0123456789abcdefghij") == 20) &&
					(mXparser.getNumeralSystemBase("b21.0123456789abcdefghijk") == 21) &&
					(mXparser.getNumeralSystemBase("b22.0123456789abcdefghijkl") == 22) &&
					(mXparser.getNumeralSystemBase("b23.0123456789abcdefghijklm") == 23) &&
					(mXparser.getNumeralSystemBase("b24.0123456789abcdefghijklmn") == 24) &&
					(mXparser.getNumeralSystemBase("b25.0123456789abcdefghijklmno") == 25) &&
					(mXparser.getNumeralSystemBase("b26.0123456789abcdefghijklmnop") == 26) &&
					(mXparser.getNumeralSystemBase("b27.0123456789abcdefghijklmnopq") == 27) &&
					(mXparser.getNumeralSystemBase("b28.0123456789abcdefghijklmnopqr") == 28) &&
					(mXparser.getNumeralSystemBase("b29.0123456789abcdefghijklmnopqrs") == 29) &&
					(mXparser.getNumeralSystemBase("b30.0123456789abcdefghijklmnopqrst") == 30) &&
					(mXparser.getNumeralSystemBase("b31.0123456789abcdefghijklmnopqrstu") == 31) &&
					(mXparser.getNumeralSystemBase("b32.0123456789abcdefghijklmnopqrstuv") == 32) &&
					(mXparser.getNumeralSystemBase("b33.0123456789abcdefghijklmnopqrstuvw") == 33) &&
					(mXparser.getNumeralSystemBase("b34.0123456789abcdefghijklmnopqrstuvwx") == 34) &&
					(mXparser.getNumeralSystemBase("b35.0123456789abcdefghijklmnopqrstuvwxy") == 35) &&
					(mXparser.getNumeralSystemBase("b36.0123456789abcdefghijklmnopqrstuvwxyz") == 36) &&
					(mXparser.getNumeralSystemBase("H.001234567890aBcDeF") == 16) &&
					(mXparser.getNumeralSystemBase("O.0012345670") == 8) &&
					(mXparser.getNumeralSystemBase("B.000101010") == 2) &&
					(mXparser.getNumeralSystemBase("B1.111") == 1) &&
					(mXparser.getNumeralSystemBase("B2.0101") == 2) &&
					(mXparser.getNumeralSystemBase("B3.0012") == 3) &&
					(mXparser.getNumeralSystemBase("B4.00123") == 4) &&
					(mXparser.getNumeralSystemBase("B5.001234") == 5) &&
					(mXparser.getNumeralSystemBase("B6.0012345") == 6) &&
					(mXparser.getNumeralSystemBase("B7.00123456") == 7) &&
					(mXparser.getNumeralSystemBase("B8.001234567") == 8) &&
					(mXparser.getNumeralSystemBase("B9.0012345678") == 9) &&
					(mXparser.getNumeralSystemBase("B10.00123456789") == 10) &&
					(mXparser.getNumeralSystemBase("B11.00123456789A") == 11) &&
					(mXparser.getNumeralSystemBase("B12.00123456789AB") == 12) &&
					(mXparser.getNumeralSystemBase("B13.00123456789ABC") == 13) &&
					(mXparser.getNumeralSystemBase("B14.00123456789ABCD") == 14) &&
					(mXparser.getNumeralSystemBase("B15.00123456789ABCDE") == 15) &&
					(mXparser.getNumeralSystemBase("B16.00123456789ABCDEF") == 16) &&
					(mXparser.getNumeralSystemBase("B16.00123456789ABCDEF") == 16) &&
					(mXparser.getNumeralSystemBase("B17.00123456789ABCDEFG") == 17) &&
					(mXparser.getNumeralSystemBase("B18.00123456789ABCDEFGH") == 18) &&
					(mXparser.getNumeralSystemBase("B19.00123456789ABCDEFGI") == 19) &&
					(mXparser.getNumeralSystemBase("B20.00123456789ABCDEFGIJ") == 20) &&
					(mXparser.getNumeralSystemBase("B21.00123456789ABCDEFGIJK") == 21) &&
					(mXparser.getNumeralSystemBase("B22.00123456789ABCDEFGIJKL") == 22) &&
					(mXparser.getNumeralSystemBase("B23.00123456789ABCDEFGIJKLM") == 23) &&
					(mXparser.getNumeralSystemBase("B24.00123456789ABCDEFGIJKLMN") == 24) &&
					(mXparser.getNumeralSystemBase("B25.00123456789ABCDEFGIJKLMNO") == 25) &&
					(mXparser.getNumeralSystemBase("B26.00123456789ABCDEFGIJKLMNOP") == 26) &&
					(mXparser.getNumeralSystemBase("B27.00123456789ABCDEFGIJKLMNOPQ") == 27) &&
					(mXparser.getNumeralSystemBase("B28.00123456789ABCDEFGIJKLMNOPQR") == 28) &&
					(mXparser.getNumeralSystemBase("B29.00123456789ABCDEFGIJKLMNOPQRS") == 29) &&
					(mXparser.getNumeralSystemBase("B30.00123456789ABCDEFGIJKLMNOPQRST") == 30) &&
					(mXparser.getNumeralSystemBase("B31.00123456789ABCDEFGIJKLMNOPQRSTU") == 31) &&
					(mXparser.getNumeralSystemBase("B32.00123456789ABCDEFGIJKLMNOPQRSTUV") == 32) &&
					(mXparser.getNumeralSystemBase("B33.00123456789ABCDEFGIJKLMNOPQRSTUVW") == 33) &&
					(mXparser.getNumeralSystemBase("B34.00123456789ABCDEFGIJKLMNOPQRSTUVWX") == 34) &&
					(mXparser.getNumeralSystemBase("B35.00123456789ABCDEFGIJKLMNOPQRSTUVWXY") == 35) &&
					(mXparser.getNumeralSystemBase("B36.00123456789ABCDEFGIJKLMNOPQRSTUVWXYZ") == 36) &&
					(mXparser.getNumeralSystemBase("-h.1234567890aBcDeF") == 16) &&
					(mXparser.getNumeralSystemBase("-o.12345670") == 8) &&
					(mXparser.getNumeralSystemBase("-b.101010") == 2) &&
					(mXparser.getNumeralSystemBase("-b1.") == 1) &&
					(mXparser.getNumeralSystemBase("-b2.01") == 2) &&
					(mXparser.getNumeralSystemBase("-b3.012") == 3) &&
					(mXparser.getNumeralSystemBase("-b4.0123") == 4) &&
					(mXparser.getNumeralSystemBase("-b5.01234") == 5) &&
					(mXparser.getNumeralSystemBase("-b6.012345") == 6) &&
					(mXparser.getNumeralSystemBase("-b7.0123456") == 7) &&
					(mXparser.getNumeralSystemBase("-b8.01234567") == 8) &&
					(mXparser.getNumeralSystemBase("-b9.012345678") == 9) &&
					(mXparser.getNumeralSystemBase("-b10.0123456789") == 10) &&
					(mXparser.getNumeralSystemBase("-b11.0123456789a") == 11) &&
					(mXparser.getNumeralSystemBase("-b12.0123456789ab") == 12) &&
					(mXparser.getNumeralSystemBase("-b13.0123456789abc") == 13) &&
					(mXparser.getNumeralSystemBase("-b14.0123456789abcd") == 14) &&
					(mXparser.getNumeralSystemBase("-b15.0123456789abcde") == 15) &&
					(mXparser.getNumeralSystemBase("-b16.0123456789abcdef") == 16) &&
					(mXparser.getNumeralSystemBase("-b16.0123456789abcdef") == 16) &&
					(mXparser.getNumeralSystemBase("-b17.0123456789abcdefg") == 17) &&
					(mXparser.getNumeralSystemBase("-b18.0123456789abcdefgh") == 18) &&
					(mXparser.getNumeralSystemBase("-b19.0123456789abcdefghi") == 19) &&
					(mXparser.getNumeralSystemBase("-b20.0123456789abcdefghij") == 20) &&
					(mXparser.getNumeralSystemBase("-b21.0123456789abcdefghijk") == 21) &&
					(mXparser.getNumeralSystemBase("-b22.0123456789abcdefghijkl") == 22) &&
					(mXparser.getNumeralSystemBase("-b23.0123456789abcdefghijklm") == 23) &&
					(mXparser.getNumeralSystemBase("-b24.0123456789abcdefghijklmn") == 24) &&
					(mXparser.getNumeralSystemBase("-b25.0123456789abcdefghijklmno") == 25) &&
					(mXparser.getNumeralSystemBase("-b26.0123456789abcdefghijklmnop") == 26) &&
					(mXparser.getNumeralSystemBase("-b27.0123456789abcdefghijklmnopq") == 27) &&
					(mXparser.getNumeralSystemBase("-b28.0123456789abcdefghijklmnopqr") == 28) &&
					(mXparser.getNumeralSystemBase("-b29.0123456789abcdefghijklmnopqrs") == 29) &&
					(mXparser.getNumeralSystemBase("-b30.0123456789abcdefghijklmnopqrst") == 30) &&
					(mXparser.getNumeralSystemBase("-b31.0123456789abcdefghijklmnopqrstu") == 31) &&
					(mXparser.getNumeralSystemBase("-b32.0123456789abcdefghijklmnopqrstuv") == 32) &&
					(mXparser.getNumeralSystemBase("-b33.0123456789abcdefghijklmnopqrstuvw") == 33) &&
					(mXparser.getNumeralSystemBase("-b34.0123456789abcdefghijklmnopqrstuvwx") == 34) &&
					(mXparser.getNumeralSystemBase("-b35.0123456789abcdefghijklmnopqrstuvwxy") == 35) &&
					(mXparser.getNumeralSystemBase("-b36.0123456789abcdefghijklmnopqrstuvwxyz") == 36) &&
					(mXparser.getNumeralSystemBase("-H.001234567890aBcDeF") == 16) &&
					(mXparser.getNumeralSystemBase("-O.0012345670") == 8) &&
					(mXparser.getNumeralSystemBase("-B.000101010") == 2) &&
					(mXparser.getNumeralSystemBase("-B1.111") == 1) &&
					(mXparser.getNumeralSystemBase("-B2.0101") == 2) &&
					(mXparser.getNumeralSystemBase("-B3.0012") == 3) &&
					(mXparser.getNumeralSystemBase("-B4.00123") == 4) &&
					(mXparser.getNumeralSystemBase("-B5.001234") == 5) &&
					(mXparser.getNumeralSystemBase("-B6.0012345") == 6) &&
					(mXparser.getNumeralSystemBase("-B7.00123456") == 7) &&
					(mXparser.getNumeralSystemBase("-B8.001234567") == 8) &&
					(mXparser.getNumeralSystemBase("-B9.0012345678") == 9) &&
					(mXparser.getNumeralSystemBase("-B10.00123456789") == 10) &&
					(mXparser.getNumeralSystemBase("-B11.00123456789A") == 11) &&
					(mXparser.getNumeralSystemBase("-B12.00123456789AB") == 12) &&
					(mXparser.getNumeralSystemBase("-B13.00123456789ABC") == 13) &&
					(mXparser.getNumeralSystemBase("-B14.00123456789ABCD") == 14) &&
					(mXparser.getNumeralSystemBase("-B15.00123456789ABCDE") == 15) &&
					(mXparser.getNumeralSystemBase("-B16.00123456789ABCDEF") == 16) &&
					(mXparser.getNumeralSystemBase("-B16.00123456789ABCDEF") == 16) &&
					(mXparser.getNumeralSystemBase("-B17.00123456789ABCDEFG") == 17) &&
					(mXparser.getNumeralSystemBase("-B18.00123456789ABCDEFGH") == 18) &&
					(mXparser.getNumeralSystemBase("-B19.00123456789ABCDEFGI") == 19) &&
					(mXparser.getNumeralSystemBase("-B20.00123456789ABCDEFGIJ") == 20) &&
					(mXparser.getNumeralSystemBase("-B21.00123456789ABCDEFGIJK") == 21) &&
					(mXparser.getNumeralSystemBase("-B22.00123456789ABCDEFGIJKL") == 22) &&
					(mXparser.getNumeralSystemBase("-B23.00123456789ABCDEFGIJKLM") == 23) &&
					(mXparser.getNumeralSystemBase("-B24.00123456789ABCDEFGIJKLMN") == 24) &&
					(mXparser.getNumeralSystemBase("-B25.00123456789ABCDEFGIJKLMNO") == 25) &&
					(mXparser.getNumeralSystemBase("-B26.00123456789ABCDEFGIJKLMNOP") == 26) &&
					(mXparser.getNumeralSystemBase("-B27.00123456789ABCDEFGIJKLMNOPQ") == 27) &&
					(mXparser.getNumeralSystemBase("-B28.00123456789ABCDEFGIJKLMNOPQR") == 28) &&
					(mXparser.getNumeralSystemBase("-B29.00123456789ABCDEFGIJKLMNOPQRS") == 29) &&
					(mXparser.getNumeralSystemBase("-B30.00123456789ABCDEFGIJKLMNOPQRST") == 30) &&
					(mXparser.getNumeralSystemBase("-B31.00123456789ABCDEFGIJKLMNOPQRSTU") == 31) &&
					(mXparser.getNumeralSystemBase("-B32.00123456789ABCDEFGIJKLMNOPQRSTUV") == 32) &&
					(mXparser.getNumeralSystemBase("-B33.00123456789ABCDEFGIJKLMNOPQRSTUVW") == 33) &&
					(mXparser.getNumeralSystemBase("-B34.00123456789ABCDEFGIJKLMNOPQRSTUVWX") == 34) &&
					(mXparser.getNumeralSystemBase("-B35.00123456789ABCDEFGIJKLMNOPQRSTUVWXY") == 35) &&
					(mXparser.getNumeralSystemBase("-B36.00123456789ABCDEFGIJKLMNOPQRSTUVWXYZ") == 36) &&
					(mXparser.getNumeralSystemBase("+h.1234567890aBcDeF") == 16) &&
					(mXparser.getNumeralSystemBase("+o.12345670") == 8) &&
					(mXparser.getNumeralSystemBase("+b.101010") == 2) &&
					(mXparser.getNumeralSystemBase("+b1.") == 1) &&
					(mXparser.getNumeralSystemBase("+b2.01") == 2) &&
					(mXparser.getNumeralSystemBase("+b3.012") == 3) &&
					(mXparser.getNumeralSystemBase("+b4.0123") == 4) &&
					(mXparser.getNumeralSystemBase("+b5.01234") == 5) &&
					(mXparser.getNumeralSystemBase("+b6.012345") == 6) &&
					(mXparser.getNumeralSystemBase("+b7.0123456") == 7) &&
					(mXparser.getNumeralSystemBase("+b8.01234567") == 8) &&
					(mXparser.getNumeralSystemBase("+b9.012345678") == 9) &&
					(mXparser.getNumeralSystemBase("+b10.0123456789") == 10) &&
					(mXparser.getNumeralSystemBase("+b11.0123456789a") == 11) &&
					(mXparser.getNumeralSystemBase("+b12.0123456789ab") == 12) &&
					(mXparser.getNumeralSystemBase("+b13.0123456789abc") == 13) &&
					(mXparser.getNumeralSystemBase("+b14.0123456789abcd") == 14) &&
					(mXparser.getNumeralSystemBase("+b15.0123456789abcde") == 15) &&
					(mXparser.getNumeralSystemBase("+b16.0123456789abcdef") == 16) &&
					(mXparser.getNumeralSystemBase("+b16.0123456789abcdef") == 16) &&
					(mXparser.getNumeralSystemBase("+b17.0123456789abcdefg") == 17) &&
					(mXparser.getNumeralSystemBase("+b18.0123456789abcdefgh") == 18) &&
					(mXparser.getNumeralSystemBase("+b19.0123456789abcdefghi") == 19) &&
					(mXparser.getNumeralSystemBase("+b20.0123456789abcdefghij") == 20) &&
					(mXparser.getNumeralSystemBase("+b21.0123456789abcdefghijk") == 21) &&
					(mXparser.getNumeralSystemBase("+b22.0123456789abcdefghijkl") == 22) &&
					(mXparser.getNumeralSystemBase("+b23.0123456789abcdefghijklm") == 23) &&
					(mXparser.getNumeralSystemBase("+b24.0123456789abcdefghijklmn") == 24) &&
					(mXparser.getNumeralSystemBase("+b25.0123456789abcdefghijklmno") == 25) &&
					(mXparser.getNumeralSystemBase("+b26.0123456789abcdefghijklmnop") == 26) &&
					(mXparser.getNumeralSystemBase("+b27.0123456789abcdefghijklmnopq") == 27) &&
					(mXparser.getNumeralSystemBase("+b28.0123456789abcdefghijklmnopqr") == 28) &&
					(mXparser.getNumeralSystemBase("+b29.0123456789abcdefghijklmnopqrs") == 29) &&
					(mXparser.getNumeralSystemBase("+b30.0123456789abcdefghijklmnopqrst") == 30) &&
					(mXparser.getNumeralSystemBase("+b31.0123456789abcdefghijklmnopqrstu") == 31) &&
					(mXparser.getNumeralSystemBase("+b32.0123456789abcdefghijklmnopqrstuv") == 32) &&
					(mXparser.getNumeralSystemBase("+b33.0123456789abcdefghijklmnopqrstuvw") == 33) &&
					(mXparser.getNumeralSystemBase("+b34.0123456789abcdefghijklmnopqrstuvwx") == 34) &&
					(mXparser.getNumeralSystemBase("+b35.0123456789abcdefghijklmnopqrstuvwxy") == 35) &&
					(mXparser.getNumeralSystemBase("+b36.0123456789abcdefghijklmnopqrstuvwxyz") == 36) &&
					(mXparser.getNumeralSystemBase("+H.001234567890aBcDeF") == 16) &&
					(mXparser.getNumeralSystemBase("+O.0012345670") == 8) &&
					(mXparser.getNumeralSystemBase("+B.000101010") == 2) &&
					(mXparser.getNumeralSystemBase("+B1.111") == 1) &&
					(mXparser.getNumeralSystemBase("+B2.0101") == 2) &&
					(mXparser.getNumeralSystemBase("+B3.0012") == 3) &&
					(mXparser.getNumeralSystemBase("+B4.00123") == 4) &&
					(mXparser.getNumeralSystemBase("+B5.001234") == 5) &&
					(mXparser.getNumeralSystemBase("+B6.0012345") == 6) &&
					(mXparser.getNumeralSystemBase("+B7.00123456") == 7) &&
					(mXparser.getNumeralSystemBase("+B8.001234567") == 8) &&
					(mXparser.getNumeralSystemBase("+B9.0012345678") == 9) &&
					(mXparser.getNumeralSystemBase("+B10.00123456789") == 10) &&
					(mXparser.getNumeralSystemBase("+B11.00123456789A") == 11) &&
					(mXparser.getNumeralSystemBase("+B12.00123456789AB") == 12) &&
					(mXparser.getNumeralSystemBase("+B13.00123456789ABC") == 13) &&
					(mXparser.getNumeralSystemBase("+B14.00123456789ABCD") == 14) &&
					(mXparser.getNumeralSystemBase("+B15.00123456789ABCDE") == 15) &&
					(mXparser.getNumeralSystemBase("+B16.00123456789ABCDEF") == 16) &&
					(mXparser.getNumeralSystemBase("+B16.00123456789ABCDEF") == 16) &&
					(mXparser.getNumeralSystemBase("+B17.00123456789ABCDEFG") == 17) &&
					(mXparser.getNumeralSystemBase("+B18.00123456789ABCDEFGH") == 18) &&
					(mXparser.getNumeralSystemBase("+B19.00123456789ABCDEFGI") == 19) &&
					(mXparser.getNumeralSystemBase("+B20.00123456789ABCDEFGIJ") == 20) &&
					(mXparser.getNumeralSystemBase("+B21.00123456789ABCDEFGIJK") == 21) &&
					(mXparser.getNumeralSystemBase("+B22.00123456789ABCDEFGIJKL") == 22) &&
					(mXparser.getNumeralSystemBase("+B23.00123456789ABCDEFGIJKLM") == 23) &&
					(mXparser.getNumeralSystemBase("+B24.00123456789ABCDEFGIJKLMN") == 24) &&
					(mXparser.getNumeralSystemBase("+B25.00123456789ABCDEFGIJKLMNO") == 25) &&
					(mXparser.getNumeralSystemBase("+B26.00123456789ABCDEFGIJKLMNOP") == 26) &&
					(mXparser.getNumeralSystemBase("+B27.00123456789ABCDEFGIJKLMNOPQ") == 27) &&
					(mXparser.getNumeralSystemBase("+B28.00123456789ABCDEFGIJKLMNOPQR") == 28) &&
					(mXparser.getNumeralSystemBase("+B29.00123456789ABCDEFGIJKLMNOPQRS") == 29) &&
					(mXparser.getNumeralSystemBase("+B30.00123456789ABCDEFGIJKLMNOPQRST") == 30) &&
					(mXparser.getNumeralSystemBase("+B31.00123456789ABCDEFGIJKLMNOPQRSTU") == 31) &&
					(mXparser.getNumeralSystemBase("+B32.00123456789ABCDEFGIJKLMNOPQRSTUV") == 32) &&
					(mXparser.getNumeralSystemBase("+B33.00123456789ABCDEFGIJKLMNOPQRSTUVW") == 33) &&
					(mXparser.getNumeralSystemBase("+B34.00123456789ABCDEFGIJKLMNOPQRSTUVWX") == 34) &&
					(mXparser.getNumeralSystemBase("+B35.00123456789ABCDEFGIJKLMNOPQRSTUVWXY") == 35) &&
					(mXparser.getNumeralSystemBase("+B36.00123456789ABCDEFGIJKLMNOPQRSTUVWXYZ") == 36)
					)
				test[testId] = true;
			/*
			 * 43. mXparser. conv oth base to decimal
			 */
			testId++;
			if (
					(mXparser.convOthBase2Decimal("b1.") == 0) &&
					(mXparser.convOthBase2Decimal("b1.111") == 3) &&
					(mXparser.convOthBase2Decimal("b2.101") == 5) &&
					(mXparser.convOthBase2Decimal("b3.121") == 16) &&
					(mXparser.convOthBase2Decimal("b4.123") == 27) &&
					(mXparser.convOthBase2Decimal("b5.341") == 96) &&
					(mXparser.convOthBase2Decimal("b6.352") == 140) &&
					(mXparser.convOthBase2Decimal("b7.256") == 139) &&
					(mXparser.convOthBase2Decimal("b8.376") == 254) &&
					(mXparser.convOthBase2Decimal("o.376") == 254) &&
					(mXparser.convOthBase2Decimal("b.101") == 5) &&
					(mXparser.convOthBase2Decimal("b9.821") == 667) &&
					(mXparser.convOthBase2Decimal("b10.394") == 394) &&
					(mXparser.convOthBase2Decimal("b11.3A7") == 480) &&
					(mXparser.convOthBase2Decimal("b12.A5B") == 1511) &&
					(mXparser.convOthBase2Decimal("b13.ACB") == 1857) &&
					(mXparser.convOthBase2Decimal("b14.2AD") == 545) &&
					(mXparser.convOthBase2Decimal("b15.BE4") == 2689) &&
					(mXparser.convOthBase2Decimal("b16.FA2") == 4002) &&
					(mXparser.convOthBase2Decimal("h.FA2") == 4002) &&
					(mXparser.convOthBase2Decimal("b17.AG6") == 3168) &&
					(mXparser.convOthBase2Decimal("b18.FGH") == 5165) &&
					(mXparser.convOthBase2Decimal("b19.2I3") == 1067) &&
					(mXparser.convOthBase2Decimal("b20.9CJ") == 3859) &&
					(mXparser.convOthBase2Decimal("b21.K5F") == 8940) &&
					(mXparser.convOthBase2Decimal("b22.FL5") == 7727) &&
					(mXparser.convOthBase2Decimal("b23.1AM") == 781) &&
					(mXparser.convOthBase2Decimal("b24.5ND") == 3445) &&
					(mXparser.convOthBase2Decimal("b25.5ND5C") == 2320762) &&
					(mXparser.convOthBase2Decimal("b26.3KPB5") == 1739639) &&
					(mXparser.convOthBase2Decimal("b27.IQH67") == 10090258) &&
					(mXparser.convOthBase2Decimal("b28.RKHB2") == 17048390) &&
					(mXparser.convOthBase2Decimal("b29.8BIFS") == 5942128) &&
					(mXparser.convOthBase2Decimal("b30.2TGJB") == 2417981) &&
					(mXparser.convOthBase2Decimal("b31.6PUC0") == 6315103) &&
					(mXparser.convOthBase2Decimal("b32.C0PV0") == 12609504) &&
					(mXparser.convOthBase2Decimal("b33.V000W") == 36763583) &&
					(mXparser.convOthBase2Decimal("b34.NP2XW") == 31721794) &&
					(mXparser.convOthBase2Decimal("b35.120Y0") == 1587565) &&
					(mXparser.convOthBase2Decimal("b36.ZZZZZ") == 60466175) &&
					(mXparser.convOthBase2Decimal("B1.") == 0) &&
					(mXparser.convOthBase2Decimal("B1.111") == 3) &&
					(mXparser.convOthBase2Decimal("B2.00101") == 5) &&
					(mXparser.convOthBase2Decimal("B3.00121") == 16) &&
					(mXparser.convOthBase2Decimal("B4.00123") == 27) &&
					(mXparser.convOthBase2Decimal("B5.00341") == 96) &&
					(mXparser.convOthBase2Decimal("B6.00352") == 140) &&
					(mXparser.convOthBase2Decimal("B7.00256") == 139) &&
					(mXparser.convOthBase2Decimal("B8.00376") == 254) &&
					(mXparser.convOthBase2Decimal("O.00376") == 254) &&
					(mXparser.convOthBase2Decimal("B.00101") == 5) &&
					(mXparser.convOthBase2Decimal("B9.00821") == 667) &&
					(mXparser.convOthBase2Decimal("B10.00394") == 394) &&
					(mXparser.convOthBase2Decimal("B11.003a7") == 480) &&
					(mXparser.convOthBase2Decimal("B12.00a5b") == 1511) &&
					(mXparser.convOthBase2Decimal("B13.00acb") == 1857) &&
					(mXparser.convOthBase2Decimal("B14.002ad") == 545) &&
					(mXparser.convOthBase2Decimal("B15.00be4") == 2689) &&
					(mXparser.convOthBase2Decimal("B16.00fa2") == 4002) &&
					(mXparser.convOthBase2Decimal("H.00fa2") == 4002) &&
					(mXparser.convOthBase2Decimal("B17.00ag6") == 3168) &&
					(mXparser.convOthBase2Decimal("B18.00fgh") == 5165) &&
					(mXparser.convOthBase2Decimal("B19.002i3") == 1067) &&
					(mXparser.convOthBase2Decimal("B20.009cj") == 3859) &&
					(mXparser.convOthBase2Decimal("B21.00k5f") == 8940) &&
					(mXparser.convOthBase2Decimal("B22.00fl5") == 7727) &&
					(mXparser.convOthBase2Decimal("B23.001am") == 781) &&
					(mXparser.convOthBase2Decimal("B24.005nd") == 3445) &&
					(mXparser.convOthBase2Decimal("B25.005nd5c") == 2320762) &&
					(mXparser.convOthBase2Decimal("B26.003kpb5") == 1739639) &&
					(mXparser.convOthBase2Decimal("B27.00iqh67") == 10090258) &&
					(mXparser.convOthBase2Decimal("B28.00rkhb2") == 17048390) &&
					(mXparser.convOthBase2Decimal("B29.008bifs") == 5942128) &&
					(mXparser.convOthBase2Decimal("B30.002tgjb") == 2417981) &&
					(mXparser.convOthBase2Decimal("B31.006puc0") == 6315103) &&
					(mXparser.convOthBase2Decimal("B32.00c0pv0") == 12609504) &&
					(mXparser.convOthBase2Decimal("B33.00v000w") == 36763583) &&
					(mXparser.convOthBase2Decimal("B34.00np2xw") == 31721794) &&
					(mXparser.convOthBase2Decimal("B35.00120y0") == 1587565) &&
					(mXparser.convOthBase2Decimal("B36.00zzzzz") == 60466175) &&
					(mXparser.convOthBase2Decimal("+b1.") == 0) &&
					(mXparser.convOthBase2Decimal("+b1.111") == 3) &&
					(mXparser.convOthBase2Decimal("+b2.101") == 5) &&
					(mXparser.convOthBase2Decimal("+b3.121") == 16) &&
					(mXparser.convOthBase2Decimal("+b4.123") == 27) &&
					(mXparser.convOthBase2Decimal("+b5.341") == 96) &&
					(mXparser.convOthBase2Decimal("+b6.352") == 140) &&
					(mXparser.convOthBase2Decimal("+b7.256") == 139) &&
					(mXparser.convOthBase2Decimal("+b8.376") == 254) &&
					(mXparser.convOthBase2Decimal("+o.376") == 254) &&
					(mXparser.convOthBase2Decimal("+b.101") == 5) &&
					(mXparser.convOthBase2Decimal("+b9.821") == 667) &&
					(mXparser.convOthBase2Decimal("+b10.394") == 394) &&
					(mXparser.convOthBase2Decimal("+b11.3A7") == 480) &&
					(mXparser.convOthBase2Decimal("+b12.A5B") == 1511) &&
					(mXparser.convOthBase2Decimal("+b13.ACB") == 1857) &&
					(mXparser.convOthBase2Decimal("+b14.2AD") == 545) &&
					(mXparser.convOthBase2Decimal("+b15.BE4") == 2689) &&
					(mXparser.convOthBase2Decimal("+b16.FA2") == 4002) &&
					(mXparser.convOthBase2Decimal("+h.FA2") == 4002) &&
					(mXparser.convOthBase2Decimal("+b17.AG6") == 3168) &&
					(mXparser.convOthBase2Decimal("+b18.FGH") == 5165) &&
					(mXparser.convOthBase2Decimal("+b19.2I3") == 1067) &&
					(mXparser.convOthBase2Decimal("+b20.9CJ") == 3859) &&
					(mXparser.convOthBase2Decimal("+b21.K5F") == 8940) &&
					(mXparser.convOthBase2Decimal("+b22.FL5") == 7727) &&
					(mXparser.convOthBase2Decimal("+b23.1AM") == 781) &&
					(mXparser.convOthBase2Decimal("+b24.5ND") == 3445) &&
					(mXparser.convOthBase2Decimal("+b25.5ND5C") == 2320762) &&
					(mXparser.convOthBase2Decimal("+b26.3KPB5") == 1739639) &&
					(mXparser.convOthBase2Decimal("+b27.IQH67") == 10090258) &&
					(mXparser.convOthBase2Decimal("+b28.RKHB2") == 17048390) &&
					(mXparser.convOthBase2Decimal("+b29.8BIFS") == 5942128) &&
					(mXparser.convOthBase2Decimal("+b30.2TGJB") == 2417981) &&
					(mXparser.convOthBase2Decimal("+b31.6PUC0") == 6315103) &&
					(mXparser.convOthBase2Decimal("+b32.C0PV0") == 12609504) &&
					(mXparser.convOthBase2Decimal("+b33.V000W") == 36763583) &&
					(mXparser.convOthBase2Decimal("+b34.NP2XW") == 31721794) &&
					(mXparser.convOthBase2Decimal("+b35.120Y0") == 1587565) &&
					(mXparser.convOthBase2Decimal("+b36.ZZZZZ") == 60466175) &&
					(mXparser.convOthBase2Decimal("+B1.") == 0) &&
					(mXparser.convOthBase2Decimal("+B1.111") == 3) &&
					(mXparser.convOthBase2Decimal("+B2.00101") == 5) &&
					(mXparser.convOthBase2Decimal("+B3.00121") == 16) &&
					(mXparser.convOthBase2Decimal("+B4.00123") == 27) &&
					(mXparser.convOthBase2Decimal("+B5.00341") == 96) &&
					(mXparser.convOthBase2Decimal("+B6.00352") == 140) &&
					(mXparser.convOthBase2Decimal("+B7.00256") == 139) &&
					(mXparser.convOthBase2Decimal("+B8.00376") == 254) &&
					(mXparser.convOthBase2Decimal("+O.00376") == 254) &&
					(mXparser.convOthBase2Decimal("+B.00101") == 5) &&
					(mXparser.convOthBase2Decimal("+B9.00821") == 667) &&
					(mXparser.convOthBase2Decimal("+B10.00394") == 394) &&
					(mXparser.convOthBase2Decimal("+B11.003a7") == 480) &&
					(mXparser.convOthBase2Decimal("+B12.00a5b") == 1511) &&
					(mXparser.convOthBase2Decimal("+B13.00acb") == 1857) &&
					(mXparser.convOthBase2Decimal("+B14.002ad") == 545) &&
					(mXparser.convOthBase2Decimal("+B15.00be4") == 2689) &&
					(mXparser.convOthBase2Decimal("+B16.00fa2") == 4002) &&
					(mXparser.convOthBase2Decimal("+H.00fa2") == 4002) &&
					(mXparser.convOthBase2Decimal("+B17.00ag6") == 3168) &&
					(mXparser.convOthBase2Decimal("+B18.00fgh") == 5165) &&
					(mXparser.convOthBase2Decimal("+B19.002i3") == 1067) &&
					(mXparser.convOthBase2Decimal("+B20.009cj") == 3859) &&
					(mXparser.convOthBase2Decimal("+B21.00k5f") == 8940) &&
					(mXparser.convOthBase2Decimal("+B22.00fl5") == 7727) &&
					(mXparser.convOthBase2Decimal("+B23.001am") == 781) &&
					(mXparser.convOthBase2Decimal("+B24.005nd") == 3445) &&
					(mXparser.convOthBase2Decimal("+B25.005nd5c") == 2320762) &&
					(mXparser.convOthBase2Decimal("+B26.003kpb5") == 1739639) &&
					(mXparser.convOthBase2Decimal("+B27.00iqh67") == 10090258) &&
					(mXparser.convOthBase2Decimal("+B28.00rkhb2") == 17048390) &&
					(mXparser.convOthBase2Decimal("+B29.008bifs") == 5942128) &&
					(mXparser.convOthBase2Decimal("+B30.002tgjb") == 2417981) &&
					(mXparser.convOthBase2Decimal("+B31.006puc0") == 6315103) &&
					(mXparser.convOthBase2Decimal("+B32.00c0pv0") == 12609504) &&
					(mXparser.convOthBase2Decimal("+B33.00v000w") == 36763583) &&
					(mXparser.convOthBase2Decimal("+B34.00np2xw") == 31721794) &&
					(mXparser.convOthBase2Decimal("+B35.00120y0") == 1587565) &&
					(mXparser.convOthBase2Decimal("+B36.00zzzzz") == 60466175) &&
					(mXparser.convOthBase2Decimal("-b1.") == -0) &&
					(mXparser.convOthBase2Decimal("-b1.111") == -3) &&
					(mXparser.convOthBase2Decimal("-b2.101") == -5) &&
					(mXparser.convOthBase2Decimal("-b3.121") == -16) &&
					(mXparser.convOthBase2Decimal("-b4.123") == -27) &&
					(mXparser.convOthBase2Decimal("-b5.341") == -96) &&
					(mXparser.convOthBase2Decimal("-b6.352") == -140) &&
					(mXparser.convOthBase2Decimal("-b7.256") == -139) &&
					(mXparser.convOthBase2Decimal("-b8.376") == -254) &&
					(mXparser.convOthBase2Decimal("-o.376") == -254) &&
					(mXparser.convOthBase2Decimal("-b.101") == -5) &&
					(mXparser.convOthBase2Decimal("-b9.821") == -667) &&
					(mXparser.convOthBase2Decimal("-b10.394") == -394) &&
					(mXparser.convOthBase2Decimal("-b11.3A7") == -480) &&
					(mXparser.convOthBase2Decimal("-b12.A5B") == -1511) &&
					(mXparser.convOthBase2Decimal("-b13.ACB") == -1857) &&
					(mXparser.convOthBase2Decimal("-b14.2AD") == -545) &&
					(mXparser.convOthBase2Decimal("-b15.BE4") == -2689) &&
					(mXparser.convOthBase2Decimal("-b16.FA2") == -4002) &&
					(mXparser.convOthBase2Decimal("-h.FA2") == -4002) &&
					(mXparser.convOthBase2Decimal("-b17.AG6") == -3168) &&
					(mXparser.convOthBase2Decimal("-b18.FGH") == -5165) &&
					(mXparser.convOthBase2Decimal("-b19.2I3") == -1067) &&
					(mXparser.convOthBase2Decimal("-b20.9CJ") == -3859) &&
					(mXparser.convOthBase2Decimal("-b21.K5F") == -8940) &&
					(mXparser.convOthBase2Decimal("-b22.FL5") == -7727) &&
					(mXparser.convOthBase2Decimal("-b23.1AM") == -781) &&
					(mXparser.convOthBase2Decimal("-b24.5ND") == -3445) &&
					(mXparser.convOthBase2Decimal("-b25.5ND5C") == -2320762) &&
					(mXparser.convOthBase2Decimal("-b26.3KPB5") == -1739639) &&
					(mXparser.convOthBase2Decimal("-b27.IQH67") == -10090258) &&
					(mXparser.convOthBase2Decimal("-b28.RKHB2") == -17048390) &&
					(mXparser.convOthBase2Decimal("-b29.8BIFS") == -5942128) &&
					(mXparser.convOthBase2Decimal("-b30.2TGJB") == -2417981) &&
					(mXparser.convOthBase2Decimal("-b31.6PUC0") == -6315103) &&
					(mXparser.convOthBase2Decimal("-b32.C0PV0") == -12609504) &&
					(mXparser.convOthBase2Decimal("-b33.V000W") == -36763583) &&
					(mXparser.convOthBase2Decimal("-b34.NP2XW") == -31721794) &&
					(mXparser.convOthBase2Decimal("-b35.120Y0") == -1587565) &&
					(mXparser.convOthBase2Decimal("-b36.ZZZZZ") == -60466175) &&
					(mXparser.convOthBase2Decimal("-B1.") == -0) &&
					(mXparser.convOthBase2Decimal("-B1.111") == -3) &&
					(mXparser.convOthBase2Decimal("-B2.00101") == -5) &&
					(mXparser.convOthBase2Decimal("-B3.00121") == -16) &&
					(mXparser.convOthBase2Decimal("-B4.00123") == -27) &&
					(mXparser.convOthBase2Decimal("-B5.00341") == -96) &&
					(mXparser.convOthBase2Decimal("-B6.00352") == -140) &&
					(mXparser.convOthBase2Decimal("-B7.00256") == -139) &&
					(mXparser.convOthBase2Decimal("-B8.00376") == -254) &&
					(mXparser.convOthBase2Decimal("-O.00376") == -254) &&
					(mXparser.convOthBase2Decimal("-B.00101") == -5) &&
					(mXparser.convOthBase2Decimal("-B9.00821") == -667) &&
					(mXparser.convOthBase2Decimal("-B10.00394") == -394) &&
					(mXparser.convOthBase2Decimal("-B11.003a7") == -480) &&
					(mXparser.convOthBase2Decimal("-B12.00a5b") == -1511) &&
					(mXparser.convOthBase2Decimal("-B13.00acb") == -1857) &&
					(mXparser.convOthBase2Decimal("-B14.002ad") == -545) &&
					(mXparser.convOthBase2Decimal("-B15.00be4") == -2689) &&
					(mXparser.convOthBase2Decimal("-B16.00fa2") == -4002) &&
					(mXparser.convOthBase2Decimal("-H.00fa2") == -4002) &&
					(mXparser.convOthBase2Decimal("-B17.00ag6") == -3168) &&
					(mXparser.convOthBase2Decimal("-B18.00fgh") == -5165) &&
					(mXparser.convOthBase2Decimal("-B19.002i3") == -1067) &&
					(mXparser.convOthBase2Decimal("-B20.009cj") == -3859) &&
					(mXparser.convOthBase2Decimal("-B21.00k5f") == -8940) &&
					(mXparser.convOthBase2Decimal("-B22.00fl5") == -7727) &&
					(mXparser.convOthBase2Decimal("-B23.001am") == -781) &&
					(mXparser.convOthBase2Decimal("-B24.005nd") == -3445) &&
					(mXparser.convOthBase2Decimal("-B25.005nd5c") == -2320762) &&
					(mXparser.convOthBase2Decimal("-B26.003kpb5") == -1739639) &&
					(mXparser.convOthBase2Decimal("-B27.00iqh67") == -10090258) &&
					(mXparser.convOthBase2Decimal("-B28.00rkhb2") == -17048390) &&
					(mXparser.convOthBase2Decimal("-B29.008bifs") == -5942128) &&
					(mXparser.convOthBase2Decimal("-B30.002tgjb") == -2417981) &&
					(mXparser.convOthBase2Decimal("-B31.006puc0") == -6315103) &&
					(mXparser.convOthBase2Decimal("-B32.00c0pv0") == -12609504) &&
					(mXparser.convOthBase2Decimal("-B33.00v000w") == -36763583) &&
					(mXparser.convOthBase2Decimal("-B34.00np2xw") == -31721794) &&
					(mXparser.convOthBase2Decimal("-B35.00120y0") == -1587565) &&
					(mXparser.convOthBase2Decimal("-B36.00zzzzz") == -60466175)
					)
				test[testId] = true;
			/*
			 * 44. mXparser. conv decimal to oth base
			 */
			testId++;
			if (
					(mXparser.convDecimal2OthBase(0, 1).Equals("")) &&
					(mXparser.convDecimal2OthBase(3, 1).Equals("111")) &&
					(mXparser.convDecimal2OthBase(5, 2).Equals("101")) &&
					(mXparser.convDecimal2OthBase(16, 3).Equals("121")) &&
					(mXparser.convDecimal2OthBase(27, 4).Equals("123")) &&
					(mXparser.convDecimal2OthBase(96, 5).Equals("341")) &&
					(mXparser.convDecimal2OthBase(140, 6).Equals("352")) &&
					(mXparser.convDecimal2OthBase(139, 7).Equals("256")) &&
					(mXparser.convDecimal2OthBase(254, 8).Equals("376")) &&
					(mXparser.convDecimal2OthBase(667, 9).Equals("821")) &&
					(mXparser.convDecimal2OthBase(394, 10).Equals("394")) &&
					(mXparser.convDecimal2OthBase(480, 11).Equals("3A7")) &&
					(mXparser.convDecimal2OthBase(1511, 12).Equals("A5B")) &&
					(mXparser.convDecimal2OthBase(1857, 13).Equals("ACB")) &&
					(mXparser.convDecimal2OthBase(545, 14).Equals("2AD")) &&
					(mXparser.convDecimal2OthBase(2689, 15).Equals("BE4")) &&
					(mXparser.convDecimal2OthBase(4002, 16).Equals("FA2")) &&
					(mXparser.convDecimal2OthBase(3168, 17).Equals("AG6")) &&
					(mXparser.convDecimal2OthBase(5165, 18).Equals("FGH")) &&
					(mXparser.convDecimal2OthBase(1067, 19).Equals("2I3")) &&
					(mXparser.convDecimal2OthBase(3859, 20).Equals("9CJ")) &&
					(mXparser.convDecimal2OthBase(8940, 21).Equals("K5F")) &&
					(mXparser.convDecimal2OthBase(7727, 22).Equals("FL5")) &&
					(mXparser.convDecimal2OthBase(781, 23).Equals("1AM")) &&
					(mXparser.convDecimal2OthBase(3445, 24).Equals("5ND")) &&
					(mXparser.convDecimal2OthBase(2320762, 25).Equals("5ND5C")) &&
					(mXparser.convDecimal2OthBase(1739639, 26).Equals("3KPB5")) &&
					(mXparser.convDecimal2OthBase(10090258, 27).Equals("IQH67")) &&
					(mXparser.convDecimal2OthBase(17048390, 28).Equals("RKHB2")) &&
					(mXparser.convDecimal2OthBase(5942128, 29).Equals("8BIFS")) &&
					(mXparser.convDecimal2OthBase(2417981, 30).Equals("2TGJB")) &&
					(mXparser.convDecimal2OthBase(6315103, 31).Equals("6PUC0")) &&
					(mXparser.convDecimal2OthBase(12609504, 32).Equals("C0PV0")) &&
					(mXparser.convDecimal2OthBase(36763583, 33).Equals("V000W")) &&
					(mXparser.convDecimal2OthBase(31721794, 34).Equals("NP2XW")) &&
					(mXparser.convDecimal2OthBase(1587565, 35).Equals("120Y0")) &&
					(mXparser.convDecimal2OthBase(60466175, 36).Equals("ZZZZZ")) &&
					(mXparser.convDecimal2OthBase(-0, 1).Equals("")) &&
					(mXparser.convDecimal2OthBase(-3, 1).Equals("-111")) &&
					(mXparser.convDecimal2OthBase(-5, 2).Equals("-101")) &&
					(mXparser.convDecimal2OthBase(-16, 3).Equals("-121")) &&
					(mXparser.convDecimal2OthBase(-27, 4).Equals("-123")) &&
					(mXparser.convDecimal2OthBase(-96, 5).Equals("-341")) &&
					(mXparser.convDecimal2OthBase(-140, 6).Equals("-352")) &&
					(mXparser.convDecimal2OthBase(-139, 7).Equals("-256")) &&
					(mXparser.convDecimal2OthBase(-254, 8).Equals("-376")) &&
					(mXparser.convDecimal2OthBase(-667, 9).Equals("-821")) &&
					(mXparser.convDecimal2OthBase(-394, 10).Equals("-394")) &&
					(mXparser.convDecimal2OthBase(-480, 11).Equals("-3A7")) &&
					(mXparser.convDecimal2OthBase(-1511, 12).Equals("-A5B")) &&
					(mXparser.convDecimal2OthBase(-1857, 13).Equals("-ACB")) &&
					(mXparser.convDecimal2OthBase(-545, 14).Equals("-2AD")) &&
					(mXparser.convDecimal2OthBase(-2689, 15).Equals("-BE4")) &&
					(mXparser.convDecimal2OthBase(-4002, 16).Equals("-FA2")) &&
					(mXparser.convDecimal2OthBase(-3168, 17).Equals("-AG6")) &&
					(mXparser.convDecimal2OthBase(-5165, 18).Equals("-FGH")) &&
					(mXparser.convDecimal2OthBase(-1067, 19).Equals("-2I3")) &&
					(mXparser.convDecimal2OthBase(-3859, 20).Equals("-9CJ")) &&
					(mXparser.convDecimal2OthBase(-8940, 21).Equals("-K5F")) &&
					(mXparser.convDecimal2OthBase(-7727, 22).Equals("-FL5")) &&
					(mXparser.convDecimal2OthBase(-781, 23).Equals("-1AM")) &&
					(mXparser.convDecimal2OthBase(-3445, 24).Equals("-5ND")) &&
					(mXparser.convDecimal2OthBase(-2320762, 25).Equals("-5ND5C")) &&
					(mXparser.convDecimal2OthBase(-1739639, 26).Equals("-3KPB5")) &&
					(mXparser.convDecimal2OthBase(-10090258, 27).Equals("-IQH67")) &&
					(mXparser.convDecimal2OthBase(-17048390, 28).Equals("-RKHB2")) &&
					(mXparser.convDecimal2OthBase(-5942128, 29).Equals("-8BIFS")) &&
					(mXparser.convDecimal2OthBase(-2417981, 30).Equals("-2TGJB")) &&
					(mXparser.convDecimal2OthBase(-6315103, 31).Equals("-6PUC0")) &&
					(mXparser.convDecimal2OthBase(-12609504, 32).Equals("-C0PV0")) &&
					(mXparser.convDecimal2OthBase(-36763583, 33).Equals("-V000W")) &&
					(mXparser.convDecimal2OthBase(-31721794, 34).Equals("-NP2XW")) &&
					(mXparser.convDecimal2OthBase(-1587565, 35).Equals("-120Y0")) &&
					(mXparser.convDecimal2OthBase(-60466175, 36).Equals("-ZZZZZ")))
				test[testId] = true;
			/*
			 * 45. mXparser. conv decimal to oth base - format 0
			 */
			testId++;
			if (
					(mXparser.convDecimal2OthBase(0, 1, 0).Equals("")) &&
					(mXparser.convDecimal2OthBase(3, 1, 0).Equals("111")) &&
					(mXparser.convDecimal2OthBase(5, 2, 0).Equals("101")) &&
					(mXparser.convDecimal2OthBase(16, 3, 0).Equals("121")) &&
					(mXparser.convDecimal2OthBase(27, 4, 0).Equals("123")) &&
					(mXparser.convDecimal2OthBase(96, 5, 0).Equals("341")) &&
					(mXparser.convDecimal2OthBase(140, 6, 0).Equals("352")) &&
					(mXparser.convDecimal2OthBase(139, 7, 0).Equals("256")) &&
					(mXparser.convDecimal2OthBase(254, 8, 0).Equals("376")) &&
					(mXparser.convDecimal2OthBase(667, 9, 0).Equals("821")) &&
					(mXparser.convDecimal2OthBase(394, 10, 0).Equals("394")) &&
					(mXparser.convDecimal2OthBase(480, 11, 0).Equals("3A7")) &&
					(mXparser.convDecimal2OthBase(1511, 12, 0).Equals("A5B")) &&
					(mXparser.convDecimal2OthBase(1857, 13, 0).Equals("ACB")) &&
					(mXparser.convDecimal2OthBase(545, 14, 0).Equals("2AD")) &&
					(mXparser.convDecimal2OthBase(2689, 15, 0).Equals("BE4")) &&
					(mXparser.convDecimal2OthBase(4002, 16, 0).Equals("FA2")) &&
					(mXparser.convDecimal2OthBase(3168, 17, 0).Equals("AG6")) &&
					(mXparser.convDecimal2OthBase(5165, 18, 0).Equals("FGH")) &&
					(mXparser.convDecimal2OthBase(1067, 19, 0).Equals("2I3")) &&
					(mXparser.convDecimal2OthBase(3859, 20, 0).Equals("9CJ")) &&
					(mXparser.convDecimal2OthBase(8940, 21, 0).Equals("K5F")) &&
					(mXparser.convDecimal2OthBase(7727, 22, 0).Equals("FL5")) &&
					(mXparser.convDecimal2OthBase(781, 23, 0).Equals("1AM")) &&
					(mXparser.convDecimal2OthBase(3445, 24, 0).Equals("5ND")) &&
					(mXparser.convDecimal2OthBase(2320762, 25, 0).Equals("5ND5C")) &&
					(mXparser.convDecimal2OthBase(1739639, 26, 0).Equals("3KPB5")) &&
					(mXparser.convDecimal2OthBase(10090258, 27, 0).Equals("IQH67")) &&
					(mXparser.convDecimal2OthBase(17048390, 28, 0).Equals("RKHB2")) &&
					(mXparser.convDecimal2OthBase(5942128, 29, 0).Equals("8BIFS")) &&
					(mXparser.convDecimal2OthBase(2417981, 30, 0).Equals("2TGJB")) &&
					(mXparser.convDecimal2OthBase(6315103, 31, 0).Equals("6PUC0")) &&
					(mXparser.convDecimal2OthBase(12609504, 32, 0).Equals("C0PV0")) &&
					(mXparser.convDecimal2OthBase(36763583, 33, 0).Equals("V000W")) &&
					(mXparser.convDecimal2OthBase(31721794, 34, 0).Equals("NP2XW")) &&
					(mXparser.convDecimal2OthBase(1587565, 35, 0).Equals("120Y0")) &&
					(mXparser.convDecimal2OthBase(60466175, 36, 0).Equals("ZZZZZ")) &&
					(mXparser.convDecimal2OthBase(-0, 1, 0).Equals("")) &&
					(mXparser.convDecimal2OthBase(-3, 1, 0).Equals("-111")) &&
					(mXparser.convDecimal2OthBase(-5, 2, 0).Equals("-101")) &&
					(mXparser.convDecimal2OthBase(-16, 3, 0).Equals("-121")) &&
					(mXparser.convDecimal2OthBase(-27, 4, 0).Equals("-123")) &&
					(mXparser.convDecimal2OthBase(-96, 5, 0).Equals("-341")) &&
					(mXparser.convDecimal2OthBase(-140, 6, 0).Equals("-352")) &&
					(mXparser.convDecimal2OthBase(-139, 7, 0).Equals("-256")) &&
					(mXparser.convDecimal2OthBase(-254, 8, 0).Equals("-376")) &&
					(mXparser.convDecimal2OthBase(-667, 9, 0).Equals("-821")) &&
					(mXparser.convDecimal2OthBase(-394, 10, 0).Equals("-394")) &&
					(mXparser.convDecimal2OthBase(-480, 11, 0).Equals("-3A7")) &&
					(mXparser.convDecimal2OthBase(-1511, 12, 0).Equals("-A5B")) &&
					(mXparser.convDecimal2OthBase(-1857, 13, 0).Equals("-ACB")) &&
					(mXparser.convDecimal2OthBase(-545, 14, 0).Equals("-2AD")) &&
					(mXparser.convDecimal2OthBase(-2689, 15, 0).Equals("-BE4")) &&
					(mXparser.convDecimal2OthBase(-4002, 16, 0).Equals("-FA2")) &&
					(mXparser.convDecimal2OthBase(-3168, 17, 0).Equals("-AG6")) &&
					(mXparser.convDecimal2OthBase(-5165, 18, 0).Equals("-FGH")) &&
					(mXparser.convDecimal2OthBase(-1067, 19, 0).Equals("-2I3")) &&
					(mXparser.convDecimal2OthBase(-3859, 20, 0).Equals("-9CJ")) &&
					(mXparser.convDecimal2OthBase(-8940, 21, 0).Equals("-K5F")) &&
					(mXparser.convDecimal2OthBase(-7727, 22, 0).Equals("-FL5")) &&
					(mXparser.convDecimal2OthBase(-781, 23, 0).Equals("-1AM")) &&
					(mXparser.convDecimal2OthBase(-3445, 24, 0).Equals("-5ND")) &&
					(mXparser.convDecimal2OthBase(-2320762, 25, 0).Equals("-5ND5C")) &&
					(mXparser.convDecimal2OthBase(-1739639, 26, 0).Equals("-3KPB5")) &&
					(mXparser.convDecimal2OthBase(-10090258, 27, 0).Equals("-IQH67")) &&
					(mXparser.convDecimal2OthBase(-17048390, 28, 0).Equals("-RKHB2")) &&
					(mXparser.convDecimal2OthBase(-5942128, 29, 0).Equals("-8BIFS")) &&
					(mXparser.convDecimal2OthBase(-2417981, 30, 0).Equals("-2TGJB")) &&
					(mXparser.convDecimal2OthBase(-6315103, 31, 0).Equals("-6PUC0")) &&
					(mXparser.convDecimal2OthBase(-12609504, 32, 0).Equals("-C0PV0")) &&
					(mXparser.convDecimal2OthBase(-36763583, 33, 0).Equals("-V000W")) &&
					(mXparser.convDecimal2OthBase(-31721794, 34, 0).Equals("-NP2XW")) &&
					(mXparser.convDecimal2OthBase(-1587565, 35, 0).Equals("-120Y0")) &&
					(mXparser.convDecimal2OthBase(-60466175, 36, 0).Equals("-ZZZZZ")))
				test[testId] = true;
			/*
			 * 46. mXparser. conv decimal to oth base - format 1
			 */
			testId++;
			if (
					(mXparser.convDecimal2OthBase(0, 1, 1).Equals("b1.")) &&
					(mXparser.convDecimal2OthBase(3, 1, 1).Equals("b1.111")) &&
					(mXparser.convDecimal2OthBase(5, 2, 1).Equals("b2.101")) &&
					(mXparser.convDecimal2OthBase(16, 3, 1).Equals("b3.121")) &&
					(mXparser.convDecimal2OthBase(27, 4, 1).Equals("b4.123")) &&
					(mXparser.convDecimal2OthBase(96, 5, 1).Equals("b5.341")) &&
					(mXparser.convDecimal2OthBase(140, 6, 1).Equals("b6.352")) &&
					(mXparser.convDecimal2OthBase(139, 7, 1).Equals("b7.256")) &&
					(mXparser.convDecimal2OthBase(254, 8, 1).Equals("b8.376")) &&
					(mXparser.convDecimal2OthBase(667, 9, 1).Equals("b9.821")) &&
					(mXparser.convDecimal2OthBase(394, 10, 1).Equals("b10.394")) &&
					(mXparser.convDecimal2OthBase(480, 11, 1).Equals("b11.3A7")) &&
					(mXparser.convDecimal2OthBase(1511, 12, 1).Equals("b12.A5B")) &&
					(mXparser.convDecimal2OthBase(1857, 13, 1).Equals("b13.ACB")) &&
					(mXparser.convDecimal2OthBase(545, 14, 1).Equals("b14.2AD")) &&
					(mXparser.convDecimal2OthBase(2689, 15, 1).Equals("b15.BE4")) &&
					(mXparser.convDecimal2OthBase(4002, 16, 1).Equals("b16.FA2")) &&
					(mXparser.convDecimal2OthBase(3168, 17, 1).Equals("b17.AG6")) &&
					(mXparser.convDecimal2OthBase(5165, 18, 1).Equals("b18.FGH")) &&
					(mXparser.convDecimal2OthBase(1067, 19, 1).Equals("b19.2I3")) &&
					(mXparser.convDecimal2OthBase(3859, 20, 1).Equals("b20.9CJ")) &&
					(mXparser.convDecimal2OthBase(8940, 21, 1).Equals("b21.K5F")) &&
					(mXparser.convDecimal2OthBase(7727, 22, 1).Equals("b22.FL5")) &&
					(mXparser.convDecimal2OthBase(781, 23, 1).Equals("b23.1AM")) &&
					(mXparser.convDecimal2OthBase(3445, 24, 1).Equals("b24.5ND")) &&
					(mXparser.convDecimal2OthBase(2320762, 25, 1).Equals("b25.5ND5C")) &&
					(mXparser.convDecimal2OthBase(1739639, 26, 1).Equals("b26.3KPB5")) &&
					(mXparser.convDecimal2OthBase(10090258, 27, 1).Equals("b27.IQH67")) &&
					(mXparser.convDecimal2OthBase(17048390, 28, 1).Equals("b28.RKHB2")) &&
					(mXparser.convDecimal2OthBase(5942128, 29, 1).Equals("b29.8BIFS")) &&
					(mXparser.convDecimal2OthBase(2417981, 30, 1).Equals("b30.2TGJB")) &&
					(mXparser.convDecimal2OthBase(6315103, 31, 1).Equals("b31.6PUC0")) &&
					(mXparser.convDecimal2OthBase(12609504, 32, 1).Equals("b32.C0PV0")) &&
					(mXparser.convDecimal2OthBase(36763583, 33, 1).Equals("b33.V000W")) &&
					(mXparser.convDecimal2OthBase(31721794, 34, 1).Equals("b34.NP2XW")) &&
					(mXparser.convDecimal2OthBase(1587565, 35, 1).Equals("b35.120Y0")) &&
					(mXparser.convDecimal2OthBase(60466175, 36, 1).Equals("b36.ZZZZZ")) &&
					(mXparser.convDecimal2OthBase(-0, 1, 1).Equals("b1.")) &&
					(mXparser.convDecimal2OthBase(-3, 1, 1).Equals("-b1.111")) &&
					(mXparser.convDecimal2OthBase(-5, 2, 1).Equals("-b2.101")) &&
					(mXparser.convDecimal2OthBase(-16, 3, 1).Equals("-b3.121")) &&
					(mXparser.convDecimal2OthBase(-27, 4, 1).Equals("-b4.123")) &&
					(mXparser.convDecimal2OthBase(-96, 5, 1).Equals("-b5.341")) &&
					(mXparser.convDecimal2OthBase(-140, 6, 1).Equals("-b6.352")) &&
					(mXparser.convDecimal2OthBase(-139, 7, 1).Equals("-b7.256")) &&
					(mXparser.convDecimal2OthBase(-254, 8, 1).Equals("-b8.376")) &&
					(mXparser.convDecimal2OthBase(-667, 9, 1).Equals("-b9.821")) &&
					(mXparser.convDecimal2OthBase(-394, 10, 1).Equals("-b10.394")) &&
					(mXparser.convDecimal2OthBase(-480, 11, 1).Equals("-b11.3A7")) &&
					(mXparser.convDecimal2OthBase(-1511, 12, 1).Equals("-b12.A5B")) &&
					(mXparser.convDecimal2OthBase(-1857, 13, 1).Equals("-b13.ACB")) &&
					(mXparser.convDecimal2OthBase(-545, 14, 1).Equals("-b14.2AD")) &&
					(mXparser.convDecimal2OthBase(-2689, 15, 1).Equals("-b15.BE4")) &&
					(mXparser.convDecimal2OthBase(-4002, 16, 1).Equals("-b16.FA2")) &&
					(mXparser.convDecimal2OthBase(-3168, 17, 1).Equals("-b17.AG6")) &&
					(mXparser.convDecimal2OthBase(-5165, 18, 1).Equals("-b18.FGH")) &&
					(mXparser.convDecimal2OthBase(-1067, 19, 1).Equals("-b19.2I3")) &&
					(mXparser.convDecimal2OthBase(-3859, 20, 1).Equals("-b20.9CJ")) &&
					(mXparser.convDecimal2OthBase(-8940, 21, 1).Equals("-b21.K5F")) &&
					(mXparser.convDecimal2OthBase(-7727, 22, 1).Equals("-b22.FL5")) &&
					(mXparser.convDecimal2OthBase(-781, 23, 1).Equals("-b23.1AM")) &&
					(mXparser.convDecimal2OthBase(-3445, 24, 1).Equals("-b24.5ND")) &&
					(mXparser.convDecimal2OthBase(-2320762, 25, 1).Equals("-b25.5ND5C")) &&
					(mXparser.convDecimal2OthBase(-1739639, 26, 1).Equals("-b26.3KPB5")) &&
					(mXparser.convDecimal2OthBase(-10090258, 27, 1).Equals("-b27.IQH67")) &&
					(mXparser.convDecimal2OthBase(-17048390, 28, 1).Equals("-b28.RKHB2")) &&
					(mXparser.convDecimal2OthBase(-5942128, 29, 1).Equals("-b29.8BIFS")) &&
					(mXparser.convDecimal2OthBase(-2417981, 30, 1).Equals("-b30.2TGJB")) &&
					(mXparser.convDecimal2OthBase(-6315103, 31, 1).Equals("-b31.6PUC0")) &&
					(mXparser.convDecimal2OthBase(-12609504, 32, 1).Equals("-b32.C0PV0")) &&
					(mXparser.convDecimal2OthBase(-36763583, 33, 1).Equals("-b33.V000W")) &&
					(mXparser.convDecimal2OthBase(-31721794, 34, 1).Equals("-b34.NP2XW")) &&
					(mXparser.convDecimal2OthBase(-1587565, 35, 1).Equals("-b35.120Y0")) &&
					(mXparser.convDecimal2OthBase(-60466175, 36, 1).Equals("-b36.ZZZZZ"))
					)
				test[testId] = true;
			/*
			 * 47. mXparser. conv decimal to oth base - format 2
			 */
			testId++;
			if (
					(mXparser.convDecimal2OthBase(0, 1, 2).Equals("b1.")) &&
					(mXparser.convDecimal2OthBase(3, 1, 2).Equals("b1.111")) &&
					(mXparser.convDecimal2OthBase(5, 2, 2).Equals("b.101")) &&
					(mXparser.convDecimal2OthBase(16, 3, 2).Equals("b3.121")) &&
					(mXparser.convDecimal2OthBase(27, 4, 2).Equals("b4.123")) &&
					(mXparser.convDecimal2OthBase(96, 5, 2).Equals("b5.341")) &&
					(mXparser.convDecimal2OthBase(140, 6, 2).Equals("b6.352")) &&
					(mXparser.convDecimal2OthBase(139, 7, 2).Equals("b7.256")) &&
					(mXparser.convDecimal2OthBase(254, 8, 2).Equals("o.376")) &&
					(mXparser.convDecimal2OthBase(667, 9, 2).Equals("b9.821")) &&
					(mXparser.convDecimal2OthBase(394, 10, 2).Equals("b10.394")) &&
					(mXparser.convDecimal2OthBase(480, 11, 2).Equals("b11.3A7")) &&
					(mXparser.convDecimal2OthBase(1511, 12, 2).Equals("b12.A5B")) &&
					(mXparser.convDecimal2OthBase(1857, 13, 2).Equals("b13.ACB")) &&
					(mXparser.convDecimal2OthBase(545, 14, 2).Equals("b14.2AD")) &&
					(mXparser.convDecimal2OthBase(2689, 15, 2).Equals("b15.BE4")) &&
					(mXparser.convDecimal2OthBase(4002, 16, 2).Equals("h.FA2")) &&
					(mXparser.convDecimal2OthBase(3168, 17, 2).Equals("b17.AG6")) &&
					(mXparser.convDecimal2OthBase(5165, 18, 2).Equals("b18.FGH")) &&
					(mXparser.convDecimal2OthBase(1067, 19, 2).Equals("b19.2I3")) &&
					(mXparser.convDecimal2OthBase(3859, 20, 2).Equals("b20.9CJ")) &&
					(mXparser.convDecimal2OthBase(8940, 21, 2).Equals("b21.K5F")) &&
					(mXparser.convDecimal2OthBase(7727, 22, 2).Equals("b22.FL5")) &&
					(mXparser.convDecimal2OthBase(781, 23, 2).Equals("b23.1AM")) &&
					(mXparser.convDecimal2OthBase(3445, 24, 2).Equals("b24.5ND")) &&
					(mXparser.convDecimal2OthBase(2320762, 25, 2).Equals("b25.5ND5C")) &&
					(mXparser.convDecimal2OthBase(1739639, 26, 2).Equals("b26.3KPB5")) &&
					(mXparser.convDecimal2OthBase(10090258, 27, 2).Equals("b27.IQH67")) &&
					(mXparser.convDecimal2OthBase(17048390, 28, 2).Equals("b28.RKHB2")) &&
					(mXparser.convDecimal2OthBase(5942128, 29, 2).Equals("b29.8BIFS")) &&
					(mXparser.convDecimal2OthBase(2417981, 30, 2).Equals("b30.2TGJB")) &&
					(mXparser.convDecimal2OthBase(6315103, 31, 2).Equals("b31.6PUC0")) &&
					(mXparser.convDecimal2OthBase(12609504, 32, 2).Equals("b32.C0PV0")) &&
					(mXparser.convDecimal2OthBase(36763583, 33, 2).Equals("b33.V000W")) &&
					(mXparser.convDecimal2OthBase(31721794, 34, 2).Equals("b34.NP2XW")) &&
					(mXparser.convDecimal2OthBase(1587565, 35, 2).Equals("b35.120Y0")) &&
					(mXparser.convDecimal2OthBase(60466175, 36, 2).Equals("b36.ZZZZZ")) &&
					(mXparser.convDecimal2OthBase(-0, 1, 2).Equals("b1.")) &&
					(mXparser.convDecimal2OthBase(-3, 1, 2).Equals("-b1.111")) &&
					(mXparser.convDecimal2OthBase(-5, 2, 2).Equals("-b.101")) &&
					(mXparser.convDecimal2OthBase(-16, 3, 2).Equals("-b3.121")) &&
					(mXparser.convDecimal2OthBase(-27, 4, 2).Equals("-b4.123")) &&
					(mXparser.convDecimal2OthBase(-96, 5, 2).Equals("-b5.341")) &&
					(mXparser.convDecimal2OthBase(-140, 6, 2).Equals("-b6.352")) &&
					(mXparser.convDecimal2OthBase(-139, 7, 2).Equals("-b7.256")) &&
					(mXparser.convDecimal2OthBase(-254, 8, 2).Equals("-o.376")) &&
					(mXparser.convDecimal2OthBase(-667, 9, 2).Equals("-b9.821")) &&
					(mXparser.convDecimal2OthBase(-394, 10, 2).Equals("-b10.394")) &&
					(mXparser.convDecimal2OthBase(-480, 11, 2).Equals("-b11.3A7")) &&
					(mXparser.convDecimal2OthBase(-1511, 12, 2).Equals("-b12.A5B")) &&
					(mXparser.convDecimal2OthBase(-1857, 13, 2).Equals("-b13.ACB")) &&
					(mXparser.convDecimal2OthBase(-545, 14, 2).Equals("-b14.2AD")) &&
					(mXparser.convDecimal2OthBase(-2689, 15, 2).Equals("-b15.BE4")) &&
					(mXparser.convDecimal2OthBase(-4002, 16, 2).Equals("-h.FA2")) &&
					(mXparser.convDecimal2OthBase(-3168, 17, 2).Equals("-b17.AG6")) &&
					(mXparser.convDecimal2OthBase(-5165, 18, 2).Equals("-b18.FGH")) &&
					(mXparser.convDecimal2OthBase(-1067, 19, 2).Equals("-b19.2I3")) &&
					(mXparser.convDecimal2OthBase(-3859, 20, 2).Equals("-b20.9CJ")) &&
					(mXparser.convDecimal2OthBase(-8940, 21, 2).Equals("-b21.K5F")) &&
					(mXparser.convDecimal2OthBase(-7727, 22, 2).Equals("-b22.FL5")) &&
					(mXparser.convDecimal2OthBase(-781, 23, 2).Equals("-b23.1AM")) &&
					(mXparser.convDecimal2OthBase(-3445, 24, 2).Equals("-b24.5ND")) &&
					(mXparser.convDecimal2OthBase(-2320762, 25, 2).Equals("-b25.5ND5C")) &&
					(mXparser.convDecimal2OthBase(-1739639, 26, 2).Equals("-b26.3KPB5")) &&
					(mXparser.convDecimal2OthBase(-10090258, 27, 2).Equals("-b27.IQH67")) &&
					(mXparser.convDecimal2OthBase(-17048390, 28, 2).Equals("-b28.RKHB2")) &&
					(mXparser.convDecimal2OthBase(-5942128, 29, 2).Equals("-b29.8BIFS")) &&
					(mXparser.convDecimal2OthBase(-2417981, 30, 2).Equals("-b30.2TGJB")) &&
					(mXparser.convDecimal2OthBase(-6315103, 31, 2).Equals("-b31.6PUC0")) &&
					(mXparser.convDecimal2OthBase(-12609504, 32, 2).Equals("-b32.C0PV0")) &&
					(mXparser.convDecimal2OthBase(-36763583, 33, 2).Equals("-b33.V000W")) &&
					(mXparser.convDecimal2OthBase(-31721794, 34, 2).Equals("-b34.NP2XW")) &&
					(mXparser.convDecimal2OthBase(-1587565, 35, 2).Equals("-b35.120Y0")) &&
					(mXparser.convDecimal2OthBase(-60466175, 36, 2).Equals("-b36.ZZZZZ"))
					)
				test[testId] = true;
			/*
			 * 48. mXparser. conv oth to decimal - special cases
			 */
			testId++;
			double potNaN1 = mXparser.convOthBase2Decimal(null);
			double potNaN2 = mXparser.convOthBase2Decimal("1");
			double potNaN3 = mXparser.convOthBase2Decimal("12");
			double potNaN4 = mXparser.convOthBase2Decimal("b1.123");
			double potNaN5 = mXparser.convOthBase2Decimal("b37.123");
			if (
					(Double.IsNaN(potNaN1)) &&
					(Double.IsNaN(potNaN2)) &&
					(Double.IsNaN(potNaN3)) &&
					(Double.IsNaN(potNaN4)) &&
					(Double.IsNaN(potNaN5))
					)
				test[testId] = true;

			/* ============================================= */
			long end =  mXparser.currentTimeMillis();
			int nOk = 0;
			int nError = 0;
			for (int i = 0; i <= testId; i++) {
				if (test[i]) {
					nOk++;
					mXparser.consolePrintln("[" + i + "] " + "OK");
				} else {
					nError++;
					mXparser.consolePrintln("[" + i + "] " + "ERROR");
				}
			}
			mXparser.consolePrintln("OK : " + nOk + ", ERRORs: " + nError + ", total time: " + (end-start)/1000.0 + " s.");
			for (int i = 0; i <= testId; i++) {
				if (!test[i])
					mXparser.consolePrintln("ERROR: " + testId);
			}
			return nError;
		}
		/**
		 * Runs API regression tests.
		 */
		public static void Main(string[] args) {
			Start();
		}
	}
}