import { useState } from "react";  


function App() {
  const [products, setProducts] = useState([
    {name: 'product1', price: 100.00},
    {name: 'product2', price: 200.00},
  ]);

  function addProduct() {
    setProducts([...products, {name: 'product3', price: 300.00}])
  }




  return (
    <div>
      <h1>Chips</h1>
      <ul>
        {products.map((item, index) =>
        <li key={index}>{item.name} - {item.price} </li>
        )}
        </ul>
        <button onClick={addProduct}> Add product</button>
        </div>
  );
}
    




export default App;
