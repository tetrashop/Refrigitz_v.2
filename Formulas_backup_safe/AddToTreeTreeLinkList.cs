//ERRORCORECTION1246789:The Link Litst Of Dummy Corected:1394/3/31
//========================================================
//ERRORCORECTION1456125478:The Righ Side instide of leftside recurve the answer:1394/3/31
//========================================================
//ERORRCORECTION646565654646:The paranterization and the state of indexpendence function variable ahs been proved.:1394/3/30
//========================================================
using System;

namespace Formulas
{
    class AddToTreeTreeLinkList
    {
        //ERRORCORECTION0917283 :The ERROR31704506 CORECTION :The Node Declared static and is shared with all classes and set nodes to deleted deleteded all nodes.
        //static LinkListNodeClass Node = null;
        public LinkListNodeClass Node = new LinkListNodeClass();
        int CurrentSize = -1;

        //int NodeNumber = 0;
        public void LinkListInizialize()
        {
            /*if(this.Node==null)
            this.Node = new LinkListNodeClass();
            if(this.Next==null)
            this.Next = new LinkListNodeClass();
            if(this.Current==null)
            this.Current = new AddToTree.Tree(null, false);            
            if(this.Thread==null)
            this.Thread = new LinkListNodeClass();                    
             */
            //  Node.Thread = null;
        }
        public AddToTreeTreeLinkList()
        {
            this.LinkListInizialize();
        }
        /*public int NodeNumberAccess
        {
            get { return NodeNumber; }
            set { NodeNumber = value; }
        }
         */
        public int CurrentSizeAccess
        {
            get { return CurrentSize; }
            set { CurrentSize = value; }
        }
        public void MULAtNumberAllOfThem(float Num)
        {
            LinkListNodeClass Dummy = Node;
            AddToTree.Tree NUM = new AddToTree.Tree(Num.ToString(), true);
            if (Dummy != null)
                while (Dummy.NextAccess != null)
                {
                    Dummy.CurrentAccess.SetLefTandRightCommonlySide(Dummy.CurrentAccess.CopyNewTree(Dummy.CurrentAccess), NUM);
                    Dummy.CurrentAccess.SampleAccess = "*";
                    Dummy = Dummy.NextAccess;
                }
        }
        public AddToTreeTreeLinkList CopyLinkList()
        {
            AddToTreeTreeLinkList t = new AddToTreeTreeLinkList();
            t.LinkListInizialize();

            t.Node = this.CopyLinkListAction(this.Node);
            t.Node.ThreadAccess = null;
            t.CurrentSizeAccess = this.CurrentSizeAccess;

            try
            {
                t.Node.CurrentAccess = this.Node.CurrentAccess.CopyNewTree(this.Node.CurrentAccess);
            }

            catch (NullReferenceException k) { ExceptionClass.ExceptionClassMethod(k); }
            return t;
        }
        LinkListNodeClass CopyLinkListAction(LinkListNodeClass Dummy)
        {
            if (Dummy == null)
                return null;
            LinkListNodeClass t = new LinkListNodeClass();
            try
            {
                t.CurrentAccess = Dummy.CurrentAccess.CopyNewTree(Dummy.CurrentAccess);
                t.NextAccess = this.CopyLinkListAction(Dummy.NextAccess);
                if (t.NextAccess != null)
                    t.NextAccess.ThreadAccess = t;
            }
            catch (NullReferenceException k) { ExceptionClass.ExceptionClassMethod(k); }
            return t;
        }
        //ERORRCORECTION646565654646:The paranterization and the state of indexpendence function variable ahs been proved.:1394/3/30
        public void CreateLinkListFromTree1(AddToTree.Tree T)
        {

            bool AD = false, Parantez = false;
            LinkListNodeClass Dummy = Node;//new LinkListNodeClass();            
            LinkListNodeClass NEW = new LinkListNodeClass();
            if (T != null)//ERRORCORECTION1246789:The Link Litst Of Dummy Corected:1394/3/31
            {
                if (T.RightSideAccess == null && T.LeftSideAccess != null && IS.IsFunction(T.SampleAccess))
                {
                    AD = true;
                    Dummy = Node;//new LinkListNodeClass();            
                    NEW = new LinkListNodeClass();
                    while (Dummy.NextAccess != null)
                        Dummy = Dummy.NextAccess;

                    NEW.CurrentAccess.SampleAccess = ")";
                    Dummy.NextAccess = NEW;
                    Dummy.NextAccess.ThreadAccess = Dummy;
                    //                NodeNumber = CurrentSize;
                    CurrentSize++;

                    CreateLinkListFromTree1(T.LeftSideAccess);//ERRORCORECTION1456125478:The Righ Side instide of leftside recurve the answer:1394/3/31

                    Dummy = Node;//new LinkListNodeClass();            
                    NEW = new LinkListNodeClass();

                    while (Dummy.NextAccess != null)
                        Dummy = Dummy.NextAccess;
                    NEW.CurrentAccess.SampleAccess = "(";
                    Dummy.NextAccess = NEW;
                    Dummy.NextAccess.ThreadAccess = Dummy;
                    CurrentSize++;



                    //CreateLinkListFromTree1(T.LeftSideAccess.RightSideAccess);


                }
                else
                //ERRORCORECTION1246789:The Link Litst Of Dummy Corected:1394/3/31
                {
                    /*if (Parantez)
                    {
                        Dummy = Node;//new LinkListNodeClass();            
                        NEW = new LinkListNodeClass();

                        while (Dummy.NextAccess != null)
                            Dummy = Dummy.NextAccess;
                        NEW.CurrentAccess.SampleAccess = ")";
                        Dummy.NextAccess = NEW;
                        Dummy.NextAccess.ThreadAccess = Dummy;
                        CurrentSize++;
                        Parantez=false;
                    } 
                     
                     */
                    CreateLinkListFromTree1(T.RightSideAccess);//ERRORCORECTION1456125478:The Righ Side instide of leftside recurve the answer:1394/3/31

                    /*if (IS.IsOperator(T.SampleAccess))
                    {
                        Dummy = Node;//new LinkListNodeClass();            
                        NEW = new LinkListNodeClass();

                        while (Dummy.NextAccess != null)
                            Dummy = Dummy.NextAccess;
                        NEW.CurrentAccess.SampleAccess = "(";
                        Dummy.NextAccess = NEW;
                        Dummy.NextAccess.ThreadAccess = Dummy;
                        CurrentSize++;
                        Parantez=true;
                    }
                    
                     */

                    Dummy = Node;//new LinkListNodeClass();            
                    NEW = new LinkListNodeClass();
                    //LinkListNodeClass NEW = new LinkListNodeClass();

                    while (Dummy.NextAccess != null)
                        Dummy = Dummy.NextAccess;
                    NEW.CurrentAccess.SampleAccess = T.SampleAccess;
                    Dummy.NextAccess = NEW;
                    Dummy.NextAccess.ThreadAccess = Dummy;
                    //                NodeNumber = CurrentSize;
                    CurrentSize++;


                    /*if (Parantez  && IS.IsOperator(T.SampleAccess))
                    {
                        Dummy = Node;//new LinkListNodeClass();            
                        NEW = new LinkListNodeClass();
                        Parantez=false;
                        while (Dummy.NextAccess != null)
                            Dummy = Dummy.NextAccess;
                        NEW.CurrentAccess.SampleAccess = ")";
                        Dummy.NextAccess = NEW;
                        Dummy.NextAccess.ThreadAccess = Dummy;
                        CurrentSize++;
                    }
                     */

                    CreateLinkListFromTree1(T.LeftSideAccess);



                }

            }
            if (AD)
            {
                AD = false;
                Dummy = Node;//new LinkListNodeClass();            
                NEW = new LinkListNodeClass();
                while (Dummy.NextAccess != null)
                    Dummy = Dummy.NextAccess;
                NEW.CurrentAccess.SampleAccess = T.SampleAccess;
                Dummy.NextAccess = NEW;
                Dummy.NextAccess.ThreadAccess = Dummy;
                CurrentSize++;

            }

        }


        public void CreateLinkListFromTree2(AddToTree.Tree T)
        {
            if (T != null)//ERRORCORECTION1246789:The Link Litst Of Dummy Corected:1394/3/31
            {
                CreateLinkListFromTree1(T.LeftSideAccess);//ERRORCORECTION1456125478:The Righ Side instide of leftside recurve the answer:1394/3/31
                LinkListNodeClass Dummy = Node;//new LinkListNodeClass();            
                LinkListNodeClass NEW = new LinkListNodeClass();

                while (Dummy.NextAccess != null)
                    Dummy = Dummy.NextAccess;
                NEW.CurrentAccess.SampleAccess = T.SampleAccess;
                Dummy.NextAccess = NEW;
                Dummy.NextAccess.ThreadAccess = Dummy;
                //                NodeNumber = CurrentSize;
                CurrentSize++;
                CreateLinkListFromTree1(T.RightSideAccess);


            }

        }

        public void ADDToTree(AddToTree.Tree T)
        {
            if (T == null)
                return;
            if (Node == null)
            {
                Node = new LinkListNodeClass();
                Node.CurrentAccess = T;
                //NodeNumber = CurrentSize + 1;
                //                NodeNumber = CurrentSize;
                CurrentSize++;
                Node.ThreadAccess = null;
            }
            else
            {
                LinkListNodeClass Dummy = Node;//new LinkListNodeClass();            
                LinkListNodeClass NEW = new LinkListNodeClass();

                while (Dummy.NextAccess != null)
                    Dummy = Dummy.NextAccess;

                if (Dummy.NextAccess == null)
                    Dummy.NextAccess = new LinkListNodeClass();
                if (Dummy.NextAccess.ThreadAccess == null)
                    Dummy.NextAccess.ThreadAccess = new LinkListNodeClass();

                NEW.CurrentAccess = T;
                Dummy.NextAccess = NEW;
                Dummy.NextAccess.ThreadAccess = Dummy;
                //                NodeNumber = CurrentSize;
                CurrentSize++;
                SetNode(Dummy);
                if (T.LeftSideAccess != null)
                    ADDToTree(T.LeftSideAccess);
                if (T.RightSideAccess != null)
                    ADDToTree(T.RightSideAccess);
            }

        }
        void SetNode(LinkListNodeClass t)
        {
            if (t != null)
                while (t.ThreadAccess != null)
                    t = t.ThreadAccess;
            Node = t;
        }
        public AddToTree.Tree DELETEFromTreeFirstNode()
        {
            AddToTree.Tree RETURN = new AddToTree.Tree(null, false);

            if (Node != null)
            {
                if (!ISEmpty())
                {
                    try
                    {
                        LinkListNodeClass Dummy = Node;

                        while (Dummy.NextAccess != null)
                            Dummy = Dummy.NextAccess;
                        RETURN = Dummy.CurrentAccess;
                        Dummy = Dummy.ThreadAccess;
                        if (Dummy != null)
                            Dummy.NextAccess = null;
                        CurrentSize--;
                        SetNode(Dummy);

                    }
                    catch (NullReferenceException t)
                    {
                        ExceptionClass.ExceptionClassMethod(t);
                        // System.Windows.Forms.MessageBox.Show("Invalide Deletion First Node.");
                    }
                }
            }
            else
                CurrentSize = -1;
            return RETURN;
        }
        public AddToTree.Tree DELETEFromTreeFindedNode(AddToTree.Tree DummyToDeleted)
        {
            AddToTree.Tree RETURN = null;
            if (Node != null)
            {
                if (!ISEmpty())
                {
                    try
                    {
                        LinkListNodeClass Dummy = Node;

                        while ((Dummy != null) && (!(EqualToObject.IsEqualWithOutThreadConsiderationCommonly(Dummy.CurrentAccess, DummyToDeleted))))
                            Dummy = Dummy.NextAccess;
                        if (Dummy != null)
                        {
                            if (Dummy.NextAccess != null)
                                Dummy.NextAccess.ThreadAccess = Dummy.ThreadAccess;
                            Dummy = Dummy.NextAccess;
                        }
                        SetNode(Dummy);
                        CurrentSize--;
                    }
                    catch (NullReferenceException t)
                    {
                        ExceptionClass.ExceptionClassMethod(t);
                        //       System.Windows.Forms.MessageBox.Show("Invalide Deletion Finded Node.");
                    }
                }
            }
            else
                CurrentSize = -1;
            return RETURN;
        }
        public bool ISEmpty()
        {
            bool Is = true;
            if (CurrentSize > -1)
                Is = false;
            else
                Is = true;
            return Is;
        }
        public bool FINDTreeWithThreadConsideration(AddToTree.Tree Dummy)
        {
            LinkListNodeClass Tracer = Node;
            try
            {

            }
            catch (NullReferenceException k) { ExceptionClass.ExceptionClassMethod(k); }
            bool Is = false;
            while (Tracer != null)
            {
                if (Tracer.CurrentAccess != null)
                    if (EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy, Tracer.CurrentAccess))
                    {
                        Is = true;
                        break;
                    }
                Tracer = Tracer.NextAccess;
            }

            return Is;
        }
        public bool FINDTreeWithOutThreadConsideration(AddToTree.Tree Dummy)
        {
            LinkListNodeClass Tracer = Node;
            try
            {

            }
            catch (NullReferenceException k) { ExceptionClass.ExceptionClassMethod(k); }
            bool Is = false;
            while (Tracer != null)
            {
                if (Tracer.CurrentAccess != null)
                    if (EqualToObject.IsEqualWithOutThreadConsiderationCommonly(Dummy, Tracer.CurrentAccess))
                    {
                        Is = true;
                        break;
                    }
                Tracer = Tracer.NextAccess;
            }
            return Is;
        }

        public bool FINDTreeWithThreadConsiderationOfIntegrals(AddToTree.Tree Dummy, out float Quefiicent)
        {
            LinkListNodeClass Tracer = Node;
            bool Is = false;
            Quefiicent = 1;
            while (Tracer != null)
            {
                if (Tracer.CurrentAccess != null)
                    if (EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy.LeftSideAccess, Tracer.CurrentAccess))
                    {
                        Is = true;
                        //break;
                        Quefiicent = (float)System.Convert.ToDouble(Dummy.RightSideAccess.SampleAccess);
                    }
                if (Tracer.CurrentAccess != null)
                    if (EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy.RightSideAccess, Tracer.CurrentAccess))
                    {
                        Is = true;
                        Quefiicent = (float)System.Convert.ToDouble(Dummy.LeftSideAccess.SampleAccess);
                        break;
                    }
                Tracer = Tracer.NextAccess;
            }
            return Is;
        }

    }
}
