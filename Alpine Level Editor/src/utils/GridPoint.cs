namespace Alpine_Level_Editor.utils {
    public class GridPoint {
        public int x; //Using ints isn't as precise
        public int y; //but is more efficient.

        public GridPoint(int x, int y) {
            this.x = x;
            this.y = y;
        }

        public override string ToString() {
            return "{" + x + ", " + y + "}";
        }
    }
}