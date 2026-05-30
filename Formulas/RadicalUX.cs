using System;
using System.Collections.Generic;
using System.Text;

namespace Formulas
{
    
    static class RadicalUX
    {
     static public AddToTree.Tree RadicalUXFX()
     {
         AddToTree.Tree UX = new AddToTree.Tree("UX", false);
         AddToTree.Tree UXFUNCTION = new AddToTree.Tree("/", false);

         AddToTree.Tree B = new AddToTree.Tree("b", false);
         AddToTree.Tree BPOWTOW = new AddToTree.Tree("b", false);
         AddToTree.Tree APOWTOW = new AddToTree.Tree("a", false);
         AddToTree.Tree BPOWTOWDIVAPOWTOW = new AddToTree.Tree("/", false);
         AddToTree.Tree BPOWTOWDIVAPOWTOWMULXMINUSX0 = new AddToTree.Tree("*", false);
         AddToTree.Tree BPOWTOWMINUSEBPOWTOWDIVAPOWTOWMULXMINUSX0 = new AddToTree.Tree("-", false);
         AddToTree.Tree TOW = new AddToTree.Tree("2", false);
         AddToTree.Tree POW = new AddToTree.Tree("^", false);
         AddToTree.Tree A = new AddToTree.Tree("a", false);
         AddToTree.Tree X0 = new AddToTree.Tree("X0", false);
         AddToTree.Tree X = new AddToTree.Tree("X", false);
         AddToTree.Tree XMINUSX0 = new AddToTree.Tree("-", false);
         AddToTree.Tree DIV = new AddToTree.Tree("/", false);
         UX.SetLefTandRightCommonlySide(UX,null);
         UX.LeftSideAccess.ThreadAccess = UX;
         UX.RightSideAccess.ThreadAccess = UX;

         BPOWTOW.SetLefTandRightCommonlySide(BPOWTOW.CopyNewTree(BPOWTOW), TOW.CopyNewTree(TOW));
         BPOWTOW.LeftSideAccess.ThreadAccess = BPOWTOW;
         BPOWTOW.RightSideAccess.ThreadAccess = BPOWTOW;

         APOWTOW.SetLefTandRightCommonlySide(APOWTOW.CopyNewTree(APOWTOW), TOW.CopyNewTree(TOW));
         APOWTOW.LeftSideAccess.ThreadAccess = APOWTOW;
         APOWTOW.RightSideAccess.ThreadAccess = APOWTOW;


         BPOWTOWDIVAPOWTOW.SetLefTandRightCommonlySide(BPOWTOW.CopyNewTree(BPOWTOW),APOWTOW.CopyNewTree(APOWTOW));
         BPOWTOWDIVAPOWTOW.LeftSideAccess.ThreadAccess = BPOWTOWDIVAPOWTOW;
         BPOWTOWDIVAPOWTOW.RightSideAccess.ThreadAccess = BPOWTOWDIVAPOWTOW;
         

         BPOWTOW.SetLefTandRightCommonlySide(BPOWTOW.CopyNewTree(BPOWTOW), TOW.CopyNewTree(TOW));
         BPOWTOW.LeftSideAccess.ThreadAccess = BPOWTOW;
         BPOWTOW.RightSideAccess.ThreadAccess = BPOWTOW;
         BPOWTOW.SampleAccess = "*";

         
         APOWTOW.SetLefTandRightCommonlySide(APOWTOW.CopyNewTree(APOWTOW), TOW.CopyNewTree(TOW));
         APOWTOW.LeftSideAccess.ThreadAccess = APOWTOW;
         APOWTOW.RightSideAccess.ThreadAccess = APOWTOW;
         APOWTOW.SampleAccess = "*";


         XMINUSX0.SetLefTandRightCommonlySide(X.CopyNewTree(X), X0.CopyNewTree(X0));
         XMINUSX0.LeftSideAccess.ThreadAccess = XMINUSX0;
         XMINUSX0.RightSideAccess.ThreadAccess = XMINUSX0;

         XMINUSX0.SetLefTandRightCommonlySide(XMINUSX0.CopyNewTree(XMINUSX0),TOW.CopyNewTree(TOW));
         XMINUSX0.LeftSideAccess.ThreadAccess = XMINUSX0;
         XMINUSX0.RightSideAccess.ThreadAccess = XMINUSX0;
         XMINUSX0.LeftSideAccess.ThreadAccess = XMINUSX0;
         XMINUSX0.SampleAccess = "^";

         BPOWTOWDIVAPOWTOWMULXMINUSX0.SetLefTandRightCommonlySide(BPOWTOWDIVAPOWTOW, XMINUSX0);
         BPOWTOWDIVAPOWTOWMULXMINUSX0.LeftSideAccess.ThreadAccess = BPOWTOWDIVAPOWTOWMULXMINUSX0;
         BPOWTOWDIVAPOWTOWMULXMINUSX0.RightSideAccess.ThreadAccess = BPOWTOWDIVAPOWTOWMULXMINUSX0;

         BPOWTOWMINUSEBPOWTOWDIVAPOWTOWMULXMINUSX0.SetLefTandRightCommonlySide(BPOWTOW.CopyNewTree(BPOWTOW), BPOWTOWDIVAPOWTOWMULXMINUSX0);
         BPOWTOWMINUSEBPOWTOWDIVAPOWTOWMULXMINUSX0.LeftSideAccess.ThreadAccess = BPOWTOWMINUSEBPOWTOWDIVAPOWTOWMULXMINUSX0;
         BPOWTOWMINUSEBPOWTOWDIVAPOWTOWMULXMINUSX0.RightSideAccess.ThreadAccess = BPOWTOWMINUSEBPOWTOWDIVAPOWTOWMULXMINUSX0;


         UXFUNCTION.SetLefTandRightCommonlySide(BPOWTOW, BPOWTOWMINUSEBPOWTOWDIVAPOWTOWMULXMINUSX0);
         UXFUNCTION.LeftSideAccess.ThreadAccess = UXFUNCTION;
         UXFUNCTION.RightSideAccess.ThreadAccess = UXFUNCTION;

         UX.SetLefTandRightCommonlySide(UXFUNCTION,null);
         UX.LeftSideAccess.ThreadAccess = UX;

         return UX;

     }
    }
}
