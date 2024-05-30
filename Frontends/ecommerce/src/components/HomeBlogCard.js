import React, { useState } from "react";
import image1 from "../images/blog-image1.jpeg";

function HomeBlogCard() {
  const [imageStyle, setImageStyle] = useState({
    width: "300px",
    paddingBottom: "1.5rem",

    cursor: "pointer",
  });

  const handleMouseEnter = () => {
    setImageStyle({
      ...imageStyle,
      position: "relative",
      top: "-5%",
      width: "300px",
      paddingBottom: "1.5rem",

      cursor: "pointer",
    });
  };

  const handleMouseLeave = () => {
    setImageStyle({
      ...imageStyle,
      top: "0",
      width: "300px",
      paddingBottom: "1.5rem",
      cursor: "pointer",
    });
  };

  return (
    <div
      className="blog"
      style={{
        border: "1px solid black",
        padding: "2rem 1rem",
        borderRadius: "14px",
      }}
    >
      <img
        src={image1}
        alt="NutriBlog"
        style={{ ...imageStyle, transition: "all .3s ease" }}
        onMouseEnter={handleMouseEnter}
        onMouseLeave={handleMouseLeave}
      ></img>
      <p style={{ borderTop: "1px solid black", paddingTop: ".3rem" }}>
        Kas Gelişimi İçin En Etkili 5 Takviye
      </p>
    </div>
  );
}

export default HomeBlogCard;
