# 📐 Refrigitz v.2 – Symbolic Math Engine

![Version](https://img.shields.io/badge/version-2.0-blue)
![Language](https://img.shields.io/badge/language-C%23-green)
![Platform](https://img.shields.io/badge/platform-.NET%20%7C%20Mono-lightgrey)
![Build](https://img.shields.io/badge/build-passing-brightgreen)
![License](https://img.shields.io/badge/license-MIT-yellow)

A powerful library for **symbolic mathematical computations** written in C#.  
It supports algebraic simplification, equation solving, differentiation, integration, and expression tree manipulation.

---

## ✨ Features

- 🔹 **Algebraic Simplification** – factorisation, expansion, common sub‑expression elimination  
- 🔹 **Equation Solving** – linear, quadratic, polynomial, and trigonometric equations  
- 🔹 **Symbolic Differentiation & Integration** – recursive derivative/integral rules  
- 🔹 **Taylor Series** – expand functions to arbitrary order  
- 🔹 **Expression Tree** – all expressions are stored as trees for easy traversal and transformation  
- 🔹 **Highly Optimised** – recursive algorithms with caching and redundant‑node removal  

---

## 📁 Project Structure

```

Formulas/
├── AddSentencesToTree.cs
├── CommonFactor.cs
├── Derivasion.cs
├── Equation.cs
├── Integral.cs
├── Simplifier.cs
├── Spliter.cs
├── Program.cs
├── Properties/
├── Resources/
├── Trianglic.gif
├── clicknrun.ico
└── ... (77 source files)

```

---

## 🚀 Compilation

### Prerequisites
- **.NET Framework 4.0+** or **Mono 5.0+**
- C# compiler (`csc` or `mcs`)

### Build
```bash
mcs -target:library -out:Refrigitz.dll \
    -r:System.Windows.Forms.dll \
    -r:System.Drawing.dll \
    -r:System.Data.dll \
    -r:System.Xml.dll \
    -r:System.Core.dll \
    $(find Formulas -name "*.cs")
```

The compiled Refrigitz.dll will be placed in the root folder.

---

📊 Build Status

Metric Result
Compilation errors 0 ✅
Warnings 66 (unused variables, harmless)
Overall status PASSING

---

🔧 Refactoring Process

This repository is the result of a thorough clean‑up and modernisation:

1. Cloned the original repository from tetrashop/Refrigitz_v.2
2. Removed everything except the Formulas folder
3. Kept only .cs files and image assets
4. Automatically added missing using statements
5. Fixed duplicate classes and .cs.cs remnants
6. Replaced broken methods that prevented compilation
7. Final build passed with zero errors on Mono in Termux

---

📄 License

This project is distributed under the MIT License.
See the original repository for full license details.

---

🙏 Acknowledgements

· Original work: tetrashop/Refrigitz_v.2
· Optimisation and bug‑fixing: automated scripts + manual review

---

Last refactored: 2026-05-30
Ready for use and further development ✅
