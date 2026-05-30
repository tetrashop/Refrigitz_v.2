```markdown
# Refrigitz - Symbolic Integral Calculator

**Refrigitz** is a symbolic integration tool for mathematical expressions, developed as a Windows Forms application (compatible with Mono on Linux). The program parses user‑input expressions, builds an abstract syntax tree (AST), applies algebraic simplification rules, and computes the indefinite integral using a collection of heuristic and recursive algorithms.

## 📌 Features

- Graphical user interface (GUI) with drag‑and‑drop expression builder  
- Support for elementary functions: `sin, cos, tan, cot, sec, csc, ln, log`  
- Algebraic simplifiers: constant folding, common sub‑factor extraction, fraction splitting  
- Integration methods:  
  - Direct rules (polynomials, `xⁿ`, `sin`, `cos`, `ln`, …)  
  - Integration by parts (`∫ f·g`)  
  - Substitution (`∫ f(u) du`)  
  - Recursive integration for power and product forms  
- Derivative‑based verification of the result  
- Graphical display of the result (editor window)  

## 🧠 Theoretical Background

The engine is based on symbolic computation principles:

1. **Expression Parsing**  
   The user‑built expression is converted into an immutable binary tree (`AddToTree.Tree`), where each node stores an operator, function name, or atom (number, variable `x`).

2. **Algebraic Simplification**  
   A multi‑stage simplifier (`Simplifier.cs`) recursively applies rewrite rules:  
   - `x + 0 → x`, `1 * x → x`, `x / x → 1`  
   - Constant arithmetic (`2+3 → 5`)  
   - Common factor extraction in sums and divisions  
   - Elimination of redundant parentheses

3. **Symbolic Integration**  
   The integrator (`Integral.cs`) traverses the AST and uses pattern matching to select the appropriate rule:  
   - **Power rule**: `∫ xⁿ dx = xⁿ⁺¹/(n+1) + C`  
   - **Exponential**: `∫ aˣ dx = aˣ/ln(a) + C`  
   - **Trigonometric**: `∫ sin x dx = -cos x + C`  
   - **Logarithmic**: `∫ 1/x dx = ln|x| + C`  
   - **Integration by parts**: `∫ f·g = f·∫g - ∫(f'·∫g)`  
   - **Recursive handling** of `∫ f(g(x))·g'(x) dx` (substitution)

4. **Verification**  
   After integration, the derivative of the result is computed (`Derivasion.cs`) and compared with the original expression numerically (within a tolerance). If the verification passes, the result is displayed; otherwise, a warning is shown.

## 🛠️ Build & Run

### Prerequisites

- **Windows**  
  - [.NET Framework 4.8](https://dotnet.microsoft.com/en-us/download/dotnet-framework) or later  
  - Visual Studio (or `csc` compiler)

- **Linux / Termux (Android)**  
  - [Mono](https://www.mono-project.com/) (version 5.20 or later)  
  - X11 environment (for GUI, e.g., `Termux:X11`)

### Build from source

1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/Refrigitz.git
   cd Refrigitz
```

1. Compile (using mcs on Linux/macOS, or csc on Windows):
   Linux / Termux
   ```bash
   mcs -target:winexe -r:System.Windows.Forms.dll -r:System.Drawing.dll -r:System.dll Formulas/*.cs -out:Refrigitz.exe
   ```
   Windows (Developer Command Prompt)
   ```cmd
   csc /target:winexe /r:System.Windows.Forms.dll /r:System.Drawing.dll /r:System.dll Formulas\*.cs /out:Refrigitz.exe
   ```
2. Run the program:
   ```bash
   mono Refrigitz.exe        # on Linux/macOS
   Refrigitz.exe             # on Windows
   ```

📁 Project Structure

```
Refrigitz/
├── Formulas/
│   ├── AddToTree/               # Immutable binary tree implementation
│   ├── AddSentencesToTree.cs    # Tree construction from user input
│   ├── Equation.cs              # Main GUI form (expression builder)
│   ├── Integral.cs              # Core integration engine
│   ├── Simplifier.cs            # Algebraic simplifier
│   ├── Derivasion.cs            # Symbolic derivative
│   ├── IS.cs, EqualToObject.cs  # Helper utilities
│   └── ... (other modules)
├── Refrigitz.exe                # Compiled binary
└── README.md
```

⚠️ Current Status & Known Issues

· Compilation – The project compiles successfully with 66 warnings (unused variables, unreachable code). These do not affect runtime behaviour.
· Runtime – The program is fully functional on Windows and Linux/Mono. Graphical rendering may require proper X11 configuration in Termux.
· Integration coverage – Not all functions (e.g., sec, csc) are fully integrated; some rely on rule‑based patterns.
· Performance – Deeply nested expressions may cause stack recursion limits; future versions should implement iterative traversal.

🚀 Future Work

· Migrate from Windows Forms to a cross‑platform framework (Avalonia, .NET MAUI)
· Replace the custom link list with List<T> and use standard collections
· Add unit tests (NUnit) for each simplification and integration rule
· Implement a proper parsing engine (e.g., with ANTLR) instead of the current button‑based builder
· Extend integration to definite integrals and numerical approximation
· Publish as a .NET 8 application with self‑contained executables

📚 References

1. Geddes, K. O., Czapor, S. R., & Labahn, G. (1992). Algorithms for Computer Algebra. Kluwer Academic Publishers.
2. Bronstein, M. (1997). Symbolic Integration I – Transcendental Functions. Springer.
3. Davenport, J. H., Siret, Y., & Tournier, E. (1993). Computer Algebra: Systems and Algorithms. Academic Press.
4. Risch, R. H. (1969). The problem of integration in finite terms. Transactions of the American Mathematical Society, 139, 167–189.

📄 License

This project is released under the MIT License.

👨‍💻 Developer

Ramin Edjlal – original design and implementation.
Maintenance and modernisation by the open‑source community.

---

Refrigitz – symbolic mathematics at your fingertips.

```

---
