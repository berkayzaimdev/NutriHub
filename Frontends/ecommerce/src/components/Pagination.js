import React from "react";
import PropTypes from "prop-types";
import "./Pagination.css"; // CSS dosyasını içe aktarma

const Pagination = ({ totalPages, currentPage, onPageChange }) => {
  const handleClick = (page) => {
    if (page !== currentPage) {
      onPageChange(page);
    }
  };

  const renderPageNumbers = () => {
    const pageNumbers = [];
    for (let i = 1; i <= totalPages; i++) {
      pageNumbers.push(
        <li
          key={i}
          className={`page-item ${currentPage === i ? "active" : ""}`}
          onClick={() => handleClick(i)}
        >
          <span className="page-link">{i}</span>
        </li>
      );
    }
    return pageNumbers;
  };

  return (
    <nav>
      <ul className="pagination">
        {currentPage > 1 && (
          <li
            className="page-item"
            onClick={() => handleClick(currentPage - 1)}
          >
            <span className="page-link">&lt;</span>
          </li>
        )}
        {renderPageNumbers()}
        {currentPage < totalPages && (
          <li
            className="page-item"
            onClick={() => handleClick(currentPage + 1)}
          >
            <span className="page-link">&gt;</span>
          </li>
        )}
      </ul>
    </nav>
  );
};

Pagination.propTypes = {
  totalPages: PropTypes.number.isRequired,
  currentPage: PropTypes.number.isRequired,
  onPageChange: PropTypes.func.isRequired,
};

export default Pagination;
