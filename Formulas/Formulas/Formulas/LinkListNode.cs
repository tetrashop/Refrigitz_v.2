namespace Formulas
{
    class LinkListNodeClass
    {
        AddToTree.Tree Current = new AddToTree.Tree(null, false);
        LinkListNodeClass Next = null;
        LinkListNodeClass Thread = null;
        public LinkListNodeClass()
        {
        }
        //Ramin Edjlal.1394/3/31
        public bool EqualLinkList(LinkListNodeClass T)
        {
            bool Is = true;
            if (T.NextAccess.NextAccess == null)
                return true;
            if (T.CurrentAccess.SampleAccess != this.CurrentAccess.SampleAccess)
                Is = false;
            if (this.NextAccess == null)
                return true;
            return Is && this.NextAccess.EqualLinkList(T.NextAccess);
        }
        //Ramin Edjlal.1394/3/31
        public bool EqualLinkList2(LinkListNodeClass T)
        {
            bool Is = true;
            if (T == null)
                return true;
            if (T.CurrentAccess.SampleAccess != this.CurrentAccess.SampleAccess)
                Is = false;
            if (this.NextAccess == null)
                return true;
            return Is && this.NextAccess.EqualLinkList(T.NextAccess);
        }
        public AddToTree.Tree CurrentAccess
        {
            set { Current = value; }
            get { return Current; }
        }
        public LinkListNodeClass NextAccess
        {
            set { Next = value; }
            get { return Next; }
        }
        public LinkListNodeClass ThreadAccess
        {
            set { Thread = value; }
            get { return Thread; }
        }

    }
}
