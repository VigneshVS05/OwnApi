import React, { useState } from 'react';
import axios from 'axios';
import "./App.css";
function App() {
  const [data, setData] = useState({})
  const [search, FindImage] = useState('')
  
  
  const url = `https://localhost:7293/api/Image/GetAllImages/${search}`

  const searchPics = (event) => {
    if (event.key === 'Enter') {
      axios.get(url).then((response) => {
        setData(response.data)
        console.log(response.data)
      })
      //setLocation('')
    }
  }
  
  return (
    
      
    <div className="app">
    
      <h1 class="heads">Find Your Images </h1>
    
    
      <div className="search">
        <input
          value={search}
          onChange={event => FindImage(event.target.value)}
          onKeyPress={searchPics}
          placeholder='Enter Image names'
            type="text" />
            <button className='btn'>Enter</button>
      </div>
      <div className="container">
        <div className="top">

          <div className="Finder"> 
            <p> ImageTypes : {data.categories}</p>
            
            
          </div>
          
          <div className="Images">
           <p className='bold'><img className='a1' src={data.imageUrl} alt={data.categories}  /></p>
          
          </div>
          
          
          
        </div>
                    
        </div>





        
      </div>
      
      

    
  );
}
export default App;