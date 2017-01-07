namespace IteratorDemo
{
    class Iterator : IAbstractIterator
    {
        private BookCollection _collection;
        private int _current = 0;
        private int _step = 1;

        // Constructor
        public Iterator(BookCollection collection)
        {
            this._collection = collection;
        }

        // Gets first item
        public Book First()
        {
            _current = 0;
            return _collection[_current] as Book;
        }

        // Gets next item
        public Book Next()
        {
            _current += _step;
            if (!IsDone)
                return _collection[_current] as Book;
            else
                return null;
        }

        // Gets or sets stepsize
        public int Step
        {
            get { return _step; }
            set { _step = value; }
        }

        // Gets current iterator item
        public Book CurrentItem
        {
            get { return _collection[_current] as Book; }
        }

        // Gets whether iteration is complete
        public bool IsDone
        {
            get { return _current >= _collection.Count; }
        }
    }
}
