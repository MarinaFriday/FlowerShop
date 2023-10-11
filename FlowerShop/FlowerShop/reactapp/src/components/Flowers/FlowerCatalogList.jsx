import React from 'react';

const FlowersCatalogList = ({ flowers }) => {
    return (
        <div>
            <h3>������ ������</h3>
            <table className="table">
                <thead>
                    <tr>
                        <th>#</th>
                        <th>��������</th>
                        <th>���������</th>
                        <th>����</th>
                        <th>������</th>
                        <th>���������</th>
                        <th>���������</th>
                    </tr>
                </thead>
                <tbody>
                    {
                        flowers.map((f, index) => (
                            <tr key={f.id}>
                                <td>{index + 1}</td>
                                <td>{f.categories.map(category => category.title)}</td>
                                <td>{f.colors.map(color => color.title)}</td>
                                <td>{f.countries.map(country => country.title)}</td>
                                <td>{f.price.toFixed(2)}</td>
                                <td>{f.count}</td>
                            </tr>
                        ))
                    }
                </tbody>
            </table>
        </div>
    );
};
export default FlowersCatalogList;