import Counter from "./components/Counter";
import { useState } from "react";

function App() {

  const [isVisible, setIsVisible] = useState(true);

  return (
    <div>
      {isVisible && <Counter />}
      <button onClick={() => setIsVisible(!isVisible)}>Toggle Counter</button>
    </div>
  );
}

export default App;
